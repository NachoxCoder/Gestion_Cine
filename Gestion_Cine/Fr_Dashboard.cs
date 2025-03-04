using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BE;
using BLL;
using Timer = System.Windows.Forms.Timer;

namespace UI
{
    public partial class Fr_Dashboard : Form
    {
        private readonly BLL_Dashboard gestorDashboard;
        //private readonly BE_Empleado usuarioActual;
        private readonly BLL_Producto gestorProducto;
        private DateTime fechaDesde;
        private DateTime fechaHasta;

        public Fr_Dashboard()
        {
            InitializeComponent();
            gestorDashboard = new BLL_Dashboard();
            gestorProducto = new BLL_Producto();
            //usuarioActual = usuario;
            fechaDesde = DateTime.Today.AddMonths(-1);
            fechaHasta = DateTime.Today;
            this.Load += Fr_Dashboard_Load;
        }

        private void Fr_Dashboard_Load(object sender, EventArgs e)
        {
            ConfigurarControlesFecha();
            ConfigurarGraficos();
            ActualizarDashboard();
            ConfigurarTimer();
        }

        private void ConfigurarControlesFecha()
        {
            dtpDesde.Value = fechaDesde;
            dtpHasta.Value = fechaHasta;
            dtpDesde.ValueChanged += (s, e) =>
            {
                fechaDesde = dtpDesde.Value;
                ActualizarDashboard();
            };
            dtpHasta.ValueChanged += (s, e) =>
            {
                fechaHasta = dtpHasta.Value;
                ActualizarDashboard();
            };
        }

        private void ConfigurarGraficos()
        {
            chartVentasMensuales.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chartVentasMensuales.ChartAreas[0].AxisX.Interval = 1;
            if(!chartVentasMensuales.Series.Any(x => x.Name == "Ventas"))
            {
                chartVentasMensuales.Series.Add("Ventas");
            }
            chartVentasMensuales.Series["Ventas"].ChartType = SeriesChartType.Column;

            if(!chartPeliculas.Series.Any(x => x.Name == "Peliculas"))
            {
                chartPeliculas.Series.Add("Peliculas");
            }
            chartPeliculas.Series["Peliculas"].ChartType = SeriesChartType.Pie;
            chartPeliculas.Series["Peliculas"].Label = "#PERCENT{P1}";

            if(!chartOcupacion.Series.Any(x => x.Name == "Ocupacion"))
            {
                chartOcupacion.Series.Add("Ocupacion");
            }
            chartOcupacion.Series["Ocupacion"].ChartType = SeriesChartType.Pie;
            chartOcupacion.Series["Ocupacion"].Label = "#VALX\n#PERCENT{P1}";
        }

            private void ActualizarDashboard()
        {
            try
            {
                var metricas = gestorDashboard.ObtenerDatos();
                ActualizarMetricas(metricas);
                ConfiguarGrilla();
                ActualizarGraficos();
                ActualizarProdcutosBajoStock();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar el Dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMetricas(Dictionary<string, object> metricas)
        {
            lblTotalClientes.Text = metricas["TotalClientes"].ToString();
            lblMembresiasActivas.Text = metricas["MembresiasActivas"].ToString();
            lblVentasDiaria.Text = $"$ {metricas["VentasHoy"]:N2}";
            lblVentasPeriodo.Text = $"$ {metricas["VentasMes"]:N2}";
        }

        private void ActualizarGraficos()
        {
            try
            {
                var metricasPorPeriodo = gestorDashboard.ObtenerDatosPorPeriodo(fechaDesde, fechaHasta);
                chartVentasMensuales.Series["Ventas"].Points.Clear();
                foreach (var item in metricasPorPeriodo)
                {
                    chartVentasMensuales.Series["Ventas"].Points.AddXY(item.Key, item.Value);
                }

                var peliculasMasVistas = gestorDashboard.ObtenerDatosPeliculas();
                chartPeliculas.Series["Peliculas"].Points.Clear();
                foreach (var item in peliculasMasVistas)
                {
                    var punto = chartPeliculas.Series["Peliculas"].Points.Add((double)item.Value);
                    punto.LegendText = item.Key;
                    punto.Label = $"{item.Value}";
                }

                var ocupacion = gestorDashboard.ObtenerDatosOcupacion();
                chartOcupacion.Series["Ocupacion"].Points.Clear();
                foreach (var item in ocupacion)
                {
                    int pointIndex = chartOcupacion.Series["Ocupacion"].Points.AddXY(item.Key, item.Value);
                    chartOcupacion.Series["Ocupacion"].Points[pointIndex].Label = $"{item.Value:N1}%";
                    chartOcupacion.Series["Ocupacion"].Points[pointIndex].LegendText = item.Key;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar gráficos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfiguarGrilla()
        {
            if(dgvLowStock.Columns.Count == 0)
            {
                dgvLowStock.AutoGenerateColumns = false;
                dgvLowStock.Columns.AddRange(
                    new DataGridViewTextBoxColumn { Name = "Producto", DataPropertyName = "NombreProducto", HeaderText = "Producto", Width = 200 },
                    new DataGridViewTextBoxColumn { Name = "Stock", DataPropertyName = "Stock", HeaderText = "Stock", Width = 100 }
                );
                dgvLowStock.DefaultCellStyle.ForeColor = Color.Red;
            }
        }

        private void ActualizarProdcutosBajoStock()
        {
            try
            {
                var productosBajoStock = gestorProducto.ListarProductosBajoStock()
                    .Select(x => new { x.NombreProducto, x.Stock }).ToList();

                dgvLowStock.DataSource = productosBajoStock;

                lblAlertaLowStock.Text = productosBajoStock.Any()
                    ? $"!ATENCION¡ Hay: {productosBajoStock.Count} productos con bajo Stock" 
                    : "No hay productos con stock bajo";
                lblAlertaLowStock.ForeColor = productosBajoStock.Any() ? Color.Red : Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos con bajo stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarTimer()
        {
            Timer timer = new Timer();
            timer.Interval = 60000;
            timer.Tick += (s, e) => ActualizarDashboard();
            timer.Start();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveDialog = new SaveFileDialog())
                {
                    saveDialog.Filter = "PDF files (*.pdf)|*.pdf|Text files (*.txt)|*.txt";
                    saveDialog.DefaultExt = "pdf";
                    saveDialog.FileName = $"Reporte_{DateTime.Now:yyyyMMdd}";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        gestorDashboard.ExportarReporte(saveDialog.FileName, fechaDesde, fechaHasta);
                        MessageBox.Show("Reporte exportado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al exportar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
