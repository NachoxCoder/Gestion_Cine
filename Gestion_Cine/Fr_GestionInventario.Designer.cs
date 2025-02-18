namespace UI
{
    partial class Fr_GestionInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            grpDatos = new GroupBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblStock = new Label();
            numStock = new NumericUpDown();
            lblPrecio = new Label();
            numPrecio = new NumericUpDown();
            btnGuardar = new Button();
            btnEliminar = new Button();
            dgvProductos = new DataGridView();
            lblAlerta = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            groupBox3 = new GroupBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            chkBxProductoActivo = new CheckBox();
            txtBxDireccionProveedor = new TextBox();
            txtBxEmailProveedor = new TextBox();
            checkBox1 = new CheckBox();
            pnlTop.SuspendLayout();
            grpDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1329, 60);
            pnlTop.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Sienna;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1329, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTIÓN DE INVENTARIO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grpDatos
            // 
            grpDatos.Controls.Add(chkBxProductoActivo);
            grpDatos.Controls.Add(lblNombre);
            grpDatos.Controls.Add(txtNombre);
            grpDatos.Controls.Add(lblDescripcion);
            grpDatos.Controls.Add(txtDescripcion);
            grpDatos.Controls.Add(lblStock);
            grpDatos.Controls.Add(numStock);
            grpDatos.Controls.Add(lblPrecio);
            grpDatos.Controls.Add(numPrecio);
            grpDatos.Location = new Point(18, 302);
            grpDatos.Name = "grpDatos";
            grpDatos.Size = new Size(397, 221);
            grpDatos.TabIndex = 1;
            grpDatos.TabStop = false;
            grpDatos.Text = "Datos del Producto";
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(20, 30);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(120, 27);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(260, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Location = new Point(20, 70);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(100, 23);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(120, 67);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(260, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(20, 110);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 23);
            lblStock.TabIndex = 4;
            lblStock.Text = "Stock:";
            // 
            // numStock
            // 
            numStock.Location = new Point(120, 107);
            numStock.Name = "numStock";
            numStock.Size = new Size(120, 27);
            numStock.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.Location = new Point(20, 150);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(100, 23);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "Precio:";
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Location = new Point(120, 147);
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(120, 27);
            numPrecio.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(10, 18, 80);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(421, 401);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(190, 40);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(421, 462);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(190, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AllowUserToDeleteRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeight = 29;
            dgvProductos.Location = new Point(18, 35);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(616, 254);
            dgvProductos.TabIndex = 4;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblAlerta
            // 
            lblAlerta.AutoSize = true;
            lblAlerta.Location = new Point(421, 302);
            lblAlerta.Name = "lblAlerta";
            lblAlerta.Size = new Size(123, 20);
            lblAlerta.TabIndex = 5;
            lblAlerta.Text = "Alerta Bajo Stock";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvProductos);
            groupBox1.Controls.Add(lblAlerta);
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(grpDatos);
            groupBox1.Location = new Point(12, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 559);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Productos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Location = new Point(669, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(648, 559);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Proveedores";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Location = new Point(18, 35);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(616, 254);
            dataGridView1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(421, 462);
            button1.Name = "button1";
            button1.Size = new Size(190, 40);
            button1.TabIndex = 3;
            button1.Text = "ELIMINAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(10, 18, 80);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(421, 401);
            button2.Name = "button2";
            button2.Size = new Size(190, 40);
            button2.TabIndex = 2;
            button2.Text = "GUARDAR";
            button2.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkBox1);
            groupBox3.Controls.Add(txtBxEmailProveedor);
            groupBox3.Controls.Add(txtBxDireccionProveedor);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(18, 302);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(397, 240);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Proveedor";
            // 
            // label2
            // 
            label2.Location = new Point(20, 30);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 0;
            label2.Text = "Razon Social:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(120, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 27);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new Point(20, 70);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 2;
            label3.Text = "CUIT:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(120, 67);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 27);
            textBox2.TabIndex = 3;
            // 
            // label4
            // 
            label4.Location = new Point(20, 110);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 4;
            label4.Text = "Direccion:";
            // 
            // label5
            // 
            label5.Location = new Point(20, 150);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 6;
            label5.Text = "Email:";
            // 
            // chkBxProductoActivo
            // 
            chkBxProductoActivo.AutoSize = true;
            chkBxProductoActivo.Location = new Point(20, 191);
            chkBxProductoActivo.Name = "chkBxProductoActivo";
            chkBxProductoActivo.Size = new Size(137, 24);
            chkBxProductoActivo.TabIndex = 8;
            chkBxProductoActivo.Text = "Producto Activo";
            chkBxProductoActivo.UseVisualStyleBackColor = true;
            // 
            // txtBxDireccionProveedor
            // 
            txtBxDireccionProveedor.Location = new Point(120, 110);
            txtBxDireccionProveedor.Name = "txtBxDireccionProveedor";
            txtBxDireccionProveedor.Size = new Size(260, 27);
            txtBxDireccionProveedor.TabIndex = 7;
            // 
            // txtBxEmailProveedor
            // 
            txtBxEmailProveedor.Location = new Point(120, 150);
            txtBxEmailProveedor.Name = "txtBxEmailProveedor";
            txtBxEmailProveedor.Size = new Size(260, 27);
            txtBxEmailProveedor.TabIndex = 8;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(20, 210);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(137, 24);
            checkBox1.TabIndex = 9;
            checkBox1.Text = "Producto Activo";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Fr_GestionInventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1329, 637);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionInventario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Inventario";
            pnlTop.ResumeLayout(false);
            grpDatos.ResumeLayout(false);
            grpDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpDatos;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblStock;
        private NumericUpDown numStock;
        private Label lblPrecio;
        private NumericUpDown numPrecio;
        private Button btnGuardar;
        private Button btnEliminar;
        private DataGridView dgvProductos;

        #endregion

        private Label lblAlerta;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox3;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private CheckBox chkBxProductoActivo;
        private CheckBox checkBox1;
        private TextBox txtBxEmailProveedor;
        private TextBox txtBxDireccionProveedor;
    }
}