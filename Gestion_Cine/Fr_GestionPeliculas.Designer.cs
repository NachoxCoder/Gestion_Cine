namespace UI
{
    partial class Fr_GestionPeliculas
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
            dgvPeliculas = new DataGridView();
            dgvFunciones = new DataGridView();
            btnGuardarPelicula = new Button();
            btnEliminarPelicula = new Button();
            groupBox1 = new GroupBox();
            btn_NuevaPelicula = new Button();
            chkPeliculaActiva = new CheckBox();
            numDuracion = new NumericUpDown();
            txtSinopsis = new TextBox();
            txtTitulo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModificarPelicula = new Button();
            groupBox2 = new GroupBox();
            btnNuevaFuncion = new Button();
            chkFuncionActiva = new CheckBox();
            dtpHoraFin = new DateTimePicker();
            dtpHoraInicio = new DateTimePicker();
            dtpFecha = new DateTimePicker();
            numPrecio = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            cmbSala = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnEliminarFuncion = new Button();
            btnModificarFuncion = new Button();
            btnGuardarFuncion = new Button();
            txtRating = new TextBox();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(10, 18, 80);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1357, 60);
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
            lblTitle.Size = new Size(1357, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "GESTION DE PELICULAS Y FUNCIONES";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dgvPeliculas.ColumnHeadersHeight = 29;
            dgvPeliculas.Location = new Point(6, 26);
            dgvPeliculas.MultiSelect = false;
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPeliculas.Size = new Size(665, 377);
            dgvPeliculas.TabIndex = 3;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // dgvFunciones
            // 
            dgvFunciones.AllowUserToAddRows = false;
            dgvFunciones.AllowUserToDeleteRows = false;
            dgvFunciones.ColumnHeadersHeight = 29;
            dgvFunciones.Location = new Point(13, 26);
            dgvFunciones.MultiSelect = false;
            dgvFunciones.Name = "dgvFunciones";
            dgvFunciones.ReadOnly = true;
            dgvFunciones.RowHeadersWidth = 51;
            dgvFunciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFunciones.Size = new Size(623, 377);
            dgvFunciones.TabIndex = 4;
            dgvFunciones.SelectionChanged += dgvFunciones_SelectionChanged;
            // 
            // btnGuardarPelicula
            // 
            btnGuardarPelicula.BackColor = Color.Sienna;
            btnGuardarPelicula.FlatStyle = FlatStyle.Flat;
            btnGuardarPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarPelicula.ForeColor = Color.White;
            btnGuardarPelicula.Location = new Point(166, 564);
            btnGuardarPelicula.Name = "btnGuardarPelicula";
            btnGuardarPelicula.Size = new Size(151, 40);
            btnGuardarPelicula.TabIndex = 7;
            btnGuardarPelicula.Text = "Guardar Pelicula";
            btnGuardarPelicula.UseVisualStyleBackColor = false;
            btnGuardarPelicula.Click += btnGuardarPelicula_Click_1;
            // 
            // btnEliminarPelicula
            // 
            btnEliminarPelicula.BackColor = Color.Red;
            btnEliminarPelicula.FlatStyle = FlatStyle.Flat;
            btnEliminarPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminarPelicula.ForeColor = Color.White;
            btnEliminarPelicula.Location = new Point(524, 563);
            btnEliminarPelicula.Name = "btnEliminarPelicula";
            btnEliminarPelicula.Size = new Size(155, 40);
            btnEliminarPelicula.TabIndex = 8;
            btnEliminarPelicula.Text = "Eliminar Pelicula";
            btnEliminarPelicula.UseVisualStyleBackColor = false;
            btnEliminarPelicula.Click += btnEliminarPelicula_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_NuevaPelicula);
            groupBox1.Controls.Add(chkPeliculaActiva);
            groupBox1.Controls.Add(numDuracion);
            groupBox1.Controls.Add(txtSinopsis);
            groupBox1.Controls.Add(txtTitulo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnModificarPelicula);
            groupBox1.Controls.Add(dgvPeliculas);
            groupBox1.Controls.Add(btnEliminarPelicula);
            groupBox1.Controls.Add(btnGuardarPelicula);
            groupBox1.Location = new Point(0, 66);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(685, 610);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Peliculas";
            // 
            // btn_NuevaPelicula
            // 
            btn_NuevaPelicula.BackColor = Color.Sienna;
            btn_NuevaPelicula.FlatStyle = FlatStyle.Flat;
            btn_NuevaPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn_NuevaPelicula.ForeColor = Color.White;
            btn_NuevaPelicula.Location = new Point(12, 564);
            btn_NuevaPelicula.Name = "btn_NuevaPelicula";
            btn_NuevaPelicula.Size = new Size(137, 40);
            btn_NuevaPelicula.TabIndex = 19;
            btn_NuevaPelicula.Text = "Nueva Pelicula";
            btn_NuevaPelicula.UseVisualStyleBackColor = false;
            btn_NuevaPelicula.Click += btn_NuevaPelicula_Click;
            // 
            // chkPeliculaActiva
            // 
            chkPeliculaActiva.AutoSize = true;
            chkPeliculaActiva.Checked = true;
            chkPeliculaActiva.CheckState = CheckState.Checked;
            chkPeliculaActiva.Location = new Point(554, 528);
            chkPeliculaActiva.Name = "chkPeliculaActiva";
            chkPeliculaActiva.Size = new Size(72, 24);
            chkPeliculaActiva.TabIndex = 18;
            chkPeliculaActiva.Text = "Activa";
            chkPeliculaActiva.UseVisualStyleBackColor = true;
            // 
            // numDuracion
            // 
            numDuracion.Location = new Point(86, 521);
            numDuracion.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numDuracion.Name = "numDuracion";
            numDuracion.Size = new Size(150, 27);
            numDuracion.TabIndex = 17;
            // 
            // txtSinopsis
            // 
            txtSinopsis.Location = new Point(86, 449);
            txtSinopsis.Multiline = true;
            txtSinopsis.Name = "txtSinopsis";
            txtSinopsis.Size = new Size(569, 66);
            txtSinopsis.TabIndex = 16;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(86, 416);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(569, 27);
            txtTitulo.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(246, 528);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 13;
            label4.Text = "Rating";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 528);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 12;
            label3.Text = "Duracion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 452);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 11;
            label2.Text = "Sinopsis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 423);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 10;
            label1.Text = "Titulo";
            // 
            // btnModificarPelicula
            // 
            btnModificarPelicula.BackColor = Color.Sienna;
            btnModificarPelicula.FlatStyle = FlatStyle.Flat;
            btnModificarPelicula.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificarPelicula.ForeColor = Color.White;
            btnModificarPelicula.Location = new Point(338, 564);
            btnModificarPelicula.Name = "btnModificarPelicula";
            btnModificarPelicula.Size = new Size(166, 40);
            btnModificarPelicula.TabIndex = 9;
            btnModificarPelicula.Text = "Modificar Pelicula";
            btnModificarPelicula.UseVisualStyleBackColor = false;
            btnModificarPelicula.Click += btnModificarPelicula_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnNuevaFuncion);
            groupBox2.Controls.Add(chkFuncionActiva);
            groupBox2.Controls.Add(dtpHoraFin);
            groupBox2.Controls.Add(dtpHoraInicio);
            groupBox2.Controls.Add(dtpFecha);
            groupBox2.Controls.Add(numPrecio);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(cmbSala);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(btnEliminarFuncion);
            groupBox2.Controls.Add(btnModificarFuncion);
            groupBox2.Controls.Add(btnGuardarFuncion);
            groupBox2.Controls.Add(dgvFunciones);
            groupBox2.Location = new Point(691, 66);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(654, 610);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "Funciones";
            // 
            // btnNuevaFuncion
            // 
            btnNuevaFuncion.BackColor = Color.Sienna;
            btnNuevaFuncion.FlatStyle = FlatStyle.Flat;
            btnNuevaFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNuevaFuncion.ForeColor = Color.White;
            btnNuevaFuncion.Location = new Point(13, 564);
            btnNuevaFuncion.Name = "btnNuevaFuncion";
            btnNuevaFuncion.Size = new Size(137, 40);
            btnNuevaFuncion.TabIndex = 22;
            btnNuevaFuncion.Text = "Nueva Funcion";
            btnNuevaFuncion.UseVisualStyleBackColor = false;
            btnNuevaFuncion.Click += btnNuevaFuncion_Click;
            // 
            // chkFuncionActiva
            // 
            chkFuncionActiva.AutoSize = true;
            chkFuncionActiva.Checked = true;
            chkFuncionActiva.CheckState = CheckState.Checked;
            chkFuncionActiva.Location = new Point(564, 502);
            chkFuncionActiva.Name = "chkFuncionActiva";
            chkFuncionActiva.Size = new Size(72, 24);
            chkFuncionActiva.TabIndex = 20;
            chkFuncionActiva.Text = "Activa";
            chkFuncionActiva.UseVisualStyleBackColor = true;
            // 
            // dtpHoraFin
            // 
            dtpHoraFin.CustomFormat = "HH:mm";
            dtpHoraFin.Format = DateTimePickerFormat.Custom;
            dtpHoraFin.Location = new Point(532, 420);
            dtpHoraFin.Name = "dtpHoraFin";
            dtpHoraFin.ShowUpDown = true;
            dtpHoraFin.Size = new Size(85, 27);
            dtpHoraFin.TabIndex = 21;
            // 
            // dtpHoraInicio
            // 
            dtpHoraInicio.CustomFormat = "HH:mm";
            dtpHoraInicio.Format = DateTimePickerFormat.Custom;
            dtpHoraInicio.Location = new Point(322, 420);
            dtpHoraInicio.Name = "dtpHoraInicio";
            dtpHoraInicio.ShowUpDown = true;
            dtpHoraInicio.Size = new Size(85, 27);
            dtpHoraInicio.TabIndex = 20;
            dtpHoraInicio.ValueChanged += dtpHoraDesde_ValueChanged;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(66, 418);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(114, 27);
            dtpFecha.TabIndex = 19;
            // 
            // numPrecio
            // 
            numPrecio.Location = new Point(366, 502);
            numPrecio.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(160, 27);
            numPrecio.TabIndex = 18;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(309, 505);
            label10.Name = "label10";
            label10.Size = new Size(50, 20);
            label10.TabIndex = 17;
            label10.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 505);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 16;
            label9.Text = "Sala";
            // 
            // cmbSala
            // 
            cmbSala.FormattingEnabled = true;
            cmbSala.Location = new Point(56, 502);
            cmbSala.Name = "cmbSala";
            cmbSala.Size = new Size(218, 28);
            cmbSala.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(461, 426);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 14;
            label8.Text = "Hora Fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(234, 425);
            label7.Name = "label7";
            label7.Size = new Size(82, 20);
            label7.TabIndex = 13;
            label7.Text = "Hora Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 423);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 12;
            label6.Text = "Fecha";
            // 
            // btnEliminarFuncion
            // 
            btnEliminarFuncion.BackColor = Color.Red;
            btnEliminarFuncion.FlatStyle = FlatStyle.Flat;
            btnEliminarFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEliminarFuncion.ForeColor = Color.White;
            btnEliminarFuncion.Location = new Point(492, 563);
            btnEliminarFuncion.Name = "btnEliminarFuncion";
            btnEliminarFuncion.Size = new Size(156, 40);
            btnEliminarFuncion.TabIndex = 10;
            btnEliminarFuncion.Text = "Eliminar Funcion";
            btnEliminarFuncion.UseVisualStyleBackColor = false;
            btnEliminarFuncion.Click += btnEliminarFuncion_Click;
            // 
            // btnModificarFuncion
            // 
            btnModificarFuncion.BackColor = Color.Sienna;
            btnModificarFuncion.FlatStyle = FlatStyle.Flat;
            btnModificarFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnModificarFuncion.ForeColor = Color.White;
            btnModificarFuncion.Location = new Point(319, 564);
            btnModificarFuncion.Name = "btnModificarFuncion";
            btnModificarFuncion.Size = new Size(167, 40);
            btnModificarFuncion.TabIndex = 11;
            btnModificarFuncion.Text = "Modificar Funcion";
            btnModificarFuncion.UseVisualStyleBackColor = false;
            btnModificarFuncion.Click += btnModificarFuncion_Click;
            // 
            // btnGuardarFuncion
            // 
            btnGuardarFuncion.BackColor = Color.Sienna;
            btnGuardarFuncion.FlatStyle = FlatStyle.Flat;
            btnGuardarFuncion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGuardarFuncion.ForeColor = Color.White;
            btnGuardarFuncion.Location = new Point(160, 564);
            btnGuardarFuncion.Name = "btnGuardarFuncion";
            btnGuardarFuncion.Size = new Size(153, 40);
            btnGuardarFuncion.TabIndex = 10;
            btnGuardarFuncion.Text = "Guardar Funcion";
            btnGuardarFuncion.UseVisualStyleBackColor = false;
            btnGuardarFuncion.Click += btnGuardarFuncion_Click;
            // 
            // txtRating
            // 
            txtRating.Location = new Point(304, 589);
            txtRating.Name = "txtRating";
            txtRating.Size = new Size(200, 27);
            txtRating.TabIndex = 18;
            // 
            // Fr_GestionPeliculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 688);
            Controls.Add(txtRating);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pnlTop);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Fr_GestionPeliculas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Películas y Funciones";
            pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFunciones).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDuracion).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvPeliculas;
        private System.Windows.Forms.DataGridView dgvFunciones;

        #endregion

        private Button btnGuardarPelicula;
        private Button btnEliminarPelicula;
        private GroupBox groupBox1;
        private Button btnModificarPelicula;
        private GroupBox groupBox2;
        private Button btnEliminarFuncion;
        private Button btnModificarFuncion;
        private Button btnGuardarFuncion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Label label6;
        private NumericUpDown numPrecio;
        private Label label10;
        private Label label9;
        private ComboBox cmbSala;
        private Label label8;
        private CheckBox chkPeliculaActiva;
        private NumericUpDown numDuracion;
        private TextBox txtSinopsis;
        private TextBox txtTitulo;
        private TextBox txtRating;
        private DateTimePicker dtpHoraInicio;
        private DateTimePicker dtpFecha;
        private DateTimePicker dtpHoraFin;
        private Button btn_NuevaPelicula;
        private CheckBox chkFuncionActiva;
        private Button btnNuevaFuncion;
    }
}