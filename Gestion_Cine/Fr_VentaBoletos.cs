﻿using BE;
using BLL;
using Gestion_Cine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UI
{
    public partial class Fr_VentaBoletos : Form
    {
        private readonly BLL_Pelicula gestorPelicula;
        private readonly BLL_Funcion gestorFuncion;
        private readonly BLL_Cliente gestorCliente;
        private readonly BLL_Butaca gestorButaca;
        //private readonly BLL_Bitacora gestorBitacora;
        private readonly BLL_Boleto gestorBoleto;
        private BE_Cliente clienteSeleccionado;
        private BE_Funcion funcionSeleccionada;
        private BE_Pelicula peliculaSeleccionada;
        private BE_Empleado usuarioActual;
        public Fr_VentaBoletos()
        {
            InitializeComponent();
            gestorPelicula = new BLL_Pelicula();
            gestorFuncion = new BLL_Funcion();
            gestorCliente = new BLL_Cliente();
            gestorButaca = new BLL_Butaca();
            //gestorBitacora = new BLL_Bitacora();
            gestorBoleto = new BLL_Boleto();
            //usuarioActual = usuario;
        }

        private void Fr_VentaBoletos_Load(object sender, EventArgs e)
        {
            CargarPeliculasDisponibles();
            ConfigurarDgvFunciones();
            CargarEstadoInicial();
        }

        private void CargarFuncionesDisponibles(BE_Pelicula pelicula)
        {
            var funciones = gestorFuncion.ConsultarFuncionesPorPelicula(pelicula.ID);
            dgvFunciones.DataSource = funciones;
            ConfigurarDgvFunciones();
        }

        private void ConfigurarDgvFunciones()
        {
            dgvFunciones.Columns.Clear();
            dgvFunciones.AutoGenerateColumns = false;

            dgvFunciones.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "PeliculaTitulo", DataPropertyName = "PeliculaTitulo", HeaderText = "Película" },
                new DataGridViewTextBoxColumn { Name = "SalaNomnbre", DataPropertyName = "SalaNombre", HeaderText = "Sala" },
                new DataGridViewTextBoxColumn { Name = "ButacasDisponibles", DataPropertyName = "AsientosDisponibles", HeaderText = "Butacas Disponibles" },
                new DataGridViewTextBoxColumn { Name = "Fecha", DataPropertyName = "Fecha", HeaderText = "Fecha" },
                new DataGridViewTextBoxColumn { Name = "Hora", DataPropertyName = "Hora", HeaderText = "Hora" },
                new DataGridViewTextBoxColumn { Name = "Precio", DataPropertyName = "Precio", HeaderText = "Precio" }
            });
        }

        private void AbrirFrRegistroCliente()
        {
            var frRegistroCliente = new Fr_GestionCliente();
            frRegistroCliente.ShowDialog();
        }


        private void dgvFunciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFunciones.CurrentRow != null)
            {
                funcionSeleccionada = (BE_Funcion)dgvFunciones.CurrentRow.DataBoundItem;
                CargarButacasDisponibles();
            }

        }

        private void CargarButacasDisponibles()
        {
            if (funcionSeleccionada != null)
            {
                var butacasDisponibles = gestorButaca.ConsultarButacasDisponibles(funcionSeleccionada.IdSala);
                panelButacas.Controls.Clear();

                foreach (var butaca in butacasDisponibles.OrderBy(b => b.Fila).ThenBy(b => b.Numero))
                {
                    var btnButaca = new Button
                    {
                        Text = $"{butaca.Fila} - {butaca.Numero}",
                        Tag = butaca,
                        Width = 40,
                        Height = 40,
                        BackColor = butaca.Disponible ? Color.LightGreen : Color.Red,
                        Margin = new Padding(2)
                    };

                    btnButaca.Click += BtnButaca_Click;
                    panelButacas.Controls.Add(btnButaca);
                }
            }
        }

        private void BtnButaca_Click(object sender, EventArgs e)
        {
            var boton = (Button)sender;
            var butaca = (BE_Butaca)boton.Tag;

            if (!butaca.Disponible)
            {
                MessageBox.Show("La butaca seleccionada no está disponible", "Butaca Ocupada",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstBxButacasSeleccionadas.Items.Contains(butaca))
            {
                lstBxButacasSeleccionadas.Items.Remove(butaca);
                boton.BackColor = System.Drawing.Color.LightGreen;
            }
            else
            {
                lstBxButacasSeleccionadas.Items.Add(butaca);
                boton.BackColor = System.Drawing.Color.Yellow;
            }

            ActualizarTotal();
        }

        private void ActualizarTotal()
        {
            decimal total = funcionSeleccionada.Precio * lstBxButacasSeleccionadas.Items.Count;
            if (clienteSeleccionado?.TieneMembresia() == true)
            {
                switch (clienteSeleccionado.DevuelveMembresiaTipo())
                {
                    case TipoMembresia.Plata:
                        total *= 0.9m;
                        break;
                    case TipoMembresia.Oro:
                        total *= 0.8m;
                        break;
                    case TipoMembresia.Premium:
                        total *= 0.7m;
                        break;
                }
            }
            lblTotal.Text = $"Total: ${total:N2}";
        }

        private void btnCompletarVenta_Click(object sender, EventArgs e)
        {
            if (!ValidarVenta())
                return;

            try
            {
                foreach (BE_Butaca butaca in lstBxButacasSeleccionadas.Items)
                {
                    var boleto = new BE_Boleto
                    {
                        IdFuncion = funcionSeleccionada.ID,
                        IdCliente = clienteSeleccionado.ID,
                        FechaVenta = DateTime.Now,
                        NumeroButaca = $"{butaca.Fila} - {butaca.Numero}"
                    };

                    if (gestorBoleto.Alta(boleto))
                    {
                        gestorButaca.OcuparButaca(butaca, funcionSeleccionada);
                    }

                }

                MessageBox.Show("Venta completada con éxito", "Venta Exitosa",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                /*gestorBitacora.Log(usuarioActual, 
                    $"Venta de {lstBxButacasSeleccionadas.Items.Count} butacas para la función: " +
                    $"{funcionSeleccionada.PeliculaTitulo()} al cliente: {clienteSeleccionado.NombreCompleto()}");*/

                LimpiarForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la venta: {ex.Message}", "Venta Fallo!",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidarVenta()
        {
            if (clienteSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un cliente", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (funcionSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una función", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (lstBxButacasSeleccionadas.Items.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una butaca", "Validacion",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void LimpiarForm()
        {
            txtClientDNI.Clear();
            clienteSeleccionado = null;
            funcionSeleccionada = null;
            lstBxButacasSeleccionadas.Items.Clear();
            lblTotal.Text = "Total: $0.00";
            CargarPeliculasDisponibles();
        }

        private void CargarEstadoInicial()
        {
            LimpiarForm();
            btnCompletarVenta.Enabled = false;
        }

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            var frRegistroCliente = new Fr_GestionCliente();
            frRegistroCliente.ShowDialog();
        }

        private void btnMembresia_Click(object sender, EventArgs e)
        {
            var frMembresia = new Fr_GestionMembresia();
            frMembresia.ShowDialog();
        }

        private void btnBuscarCliente_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClientDNI.Text))
            {
                MessageBox.Show("Debe ingresar un DNI", "Campo Requerido",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clienteSeleccionado = gestorCliente.Consultar().FirstOrDefault(x => x.DNI == txtClientDNI.Text.Trim());
            if (clienteSeleccionado == null)
            {
                if (MessageBox.Show("No se encontró un cliente con ese DNI, ¿Desea registrarlo", "Nuevo Cliente",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    AbrirFrRegistroCliente();
                }
            }
            else
            {
                MostrarInfoCliente();
            }
        }

        private void MostrarInfoCliente()
        {
            if (clienteSeleccionado != null)
            {
                txtNombreCliente.Text = clienteSeleccionado.NombreCompleto();
                txtMembresiaCliente.Text = clienteSeleccionado.TieneMembresia() ?
                    clienteSeleccionado.DevuelveMembresiaTipo().ToString() : "Ninguna";
            }
        }

        private void CargarPeliculasDisponibles()
        {
            dgvPeliculas.DataSource = gestorPelicula.ConsultarPeliculasConFuncionesDisponibles();
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPeliculas.CurrentRow != null)
            {
                peliculaSeleccionada = (BE_Pelicula)dgvPeliculas.CurrentRow.DataBoundItem;
                CargarFuncionesDisponibles(peliculaSeleccionada);
            }
        }
    }
}