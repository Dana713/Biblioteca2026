namespace Biblioteca.Forms
{
    partial class FrmPrestamos
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblFechaPrestamo;
        private System.Windows.Forms.Label lblFechaLimite;
        private System.Windows.Forms.Label lblPrestamosActivos;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.ComboBox cmbAlumno;
        private System.Windows.Forms.ComboBox cmbLibro;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DateTimePicker dtpFechaPrestamo;
        private System.Windows.Forms.DateTimePicker dtpFechaLimite;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTituloDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidadDetalle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblFechaPrestamo = new System.Windows.Forms.Label();
            this.lblFechaLimite = new System.Windows.Forms.Label();
            this.lblPrestamosActivos = new System.Windows.Forms.Label();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.cmbAlumno = new System.Windows.Forms.ComboBox();
            this.cmbLibro = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dtpFechaPrestamo = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaLimite = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            //
            // lblAlumno
            //
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(20, 25);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 0;
            this.lblAlumno.Text = "Alumno:";
            //
            // lblLibro
            //
            this.lblLibro.AutoSize = true;
            this.lblLibro.Location = new System.Drawing.Point(450, 25);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(33, 13);
            this.lblLibro.TabIndex = 1;
            this.lblLibro.Text = "Libro:";
            //
            // lblCantidad
            //
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(20, 60);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            //
            // lblFechaPrestamo
            //
            this.lblFechaPrestamo.AutoSize = true;
            this.lblFechaPrestamo.Location = new System.Drawing.Point(220, 60);
            this.lblFechaPrestamo.Name = "lblFechaPrestamo";
            this.lblFechaPrestamo.Size = new System.Drawing.Size(98, 13);
            this.lblFechaPrestamo.TabIndex = 3;
            this.lblFechaPrestamo.Text = "Fecha de préstamo:";
            //
            // lblFechaLimite
            //
            this.lblFechaLimite.AutoSize = true;
            this.lblFechaLimite.Location = new System.Drawing.Point(500, 60);
            this.lblFechaLimite.Name = "lblFechaLimite";
            this.lblFechaLimite.Size = new System.Drawing.Size(82, 13);
            this.lblFechaLimite.TabIndex = 4;
            this.lblFechaLimite.Text = "Fecha límite:";
            //
            // lblPrestamosActivos
            //
            this.lblPrestamosActivos.AutoSize = true;
            this.lblPrestamosActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrestamosActivos.Location = new System.Drawing.Point(20, 140);
            this.lblPrestamosActivos.Name = "lblPrestamosActivos";
            this.lblPrestamosActivos.Size = new System.Drawing.Size(109, 15);
            this.lblPrestamosActivos.TabIndex = 5;
            this.lblPrestamosActivos.Text = "Préstamos activos";
            //
            // lblDetalle
            //
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetalle.Location = new System.Drawing.Point(20, 335);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(192, 15);
            this.lblDetalle.TabIndex = 6;
            this.lblDetalle.Text = "Detalle del préstamo seleccionado";
            //
            // cmbAlumno
            //
            this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlumno.FormattingEnabled = true;
            this.cmbAlumno.Location = new System.Drawing.Point(110, 22);
            this.cmbAlumno.Name = "cmbAlumno";
            this.cmbAlumno.Size = new System.Drawing.Size(300, 21);
            this.cmbAlumno.TabIndex = 7;
            //
            // cmbLibro
            //
            this.cmbLibro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLibro.FormattingEnabled = true;
            this.cmbLibro.Location = new System.Drawing.Point(520, 22);
            this.cmbLibro.Name = "cmbLibro";
            this.cmbLibro.Size = new System.Drawing.Size(300, 21);
            this.cmbLibro.TabIndex = 8;
            //
            // txtCantidad
            //
            this.txtCantidad.Location = new System.Drawing.Point(110, 57);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(80, 20);
            this.txtCantidad.TabIndex = 9;
            //
            // dtpFechaPrestamo
            //
            this.dtpFechaPrestamo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPrestamo.Location = new System.Drawing.Point(330, 57);
            this.dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            this.dtpFechaPrestamo.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaPrestamo.TabIndex = 10;
            //
            // dtpFechaLimite
            //
            this.dtpFechaLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaLimite.Location = new System.Drawing.Point(600, 57);
            this.dtpFechaLimite.Name = "dtpFechaLimite";
            this.dtpFechaLimite.Size = new System.Drawing.Size(150, 20);
            this.dtpFechaLimite.TabIndex = 11;
            //
            // btnRegistrar
            //
            this.btnRegistrar.Location = new System.Drawing.Point(20, 95);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(150, 30);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar préstamo";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            //
            // btnActualizar
            //
            this.btnActualizar.Location = new System.Drawing.Point(190, 95);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(150, 30);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar listas";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(360, 95);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // dgvPrestamos
            //
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colMatricula,
            this.colNombreAlumno,
            this.colFechaPrestamo,
            this.colFechaLimite,
            this.colEstado});
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 160);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(860, 165);
            this.dgvPrestamos.TabIndex = 15;
            this.dgvPrestamos.SelectionChanged += new System.EventHandler(this.dgvPrestamos_SelectionChanged);
            //
            // dgvDetalles
            //
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTituloDetalle,
            this.colCantidadDetalle});
            this.dgvDetalles.Location = new System.Drawing.Point(20, 355);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(860, 215);
            this.dgvDetalles.TabIndex = 16;
            //
            // colID
            //
            this.colID.DataPropertyName = "ID";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.Width = 50;
            //
            // colMatricula
            //
            this.colMatricula.DataPropertyName = "Matricula";
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Width = 90;
            //
            // colNombreAlumno
            //
            this.colNombreAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreAlumno.DataPropertyName = "NombreAlumno";
            this.colNombreAlumno.HeaderText = "Alumno";
            this.colNombreAlumno.Name = "colNombreAlumno";
            //
            // colFechaPrestamo
            //
            this.colFechaPrestamo.DataPropertyName = "FechaPrestamo";
            this.colFechaPrestamo.HeaderText = "Fecha préstamo";
            this.colFechaPrestamo.Name = "colFechaPrestamo";
            this.colFechaPrestamo.Width = 110;
            //
            // colFechaLimite
            //
            this.colFechaLimite.DataPropertyName = "FechaLimite";
            this.colFechaLimite.HeaderText = "Fecha límite";
            this.colFechaLimite.Name = "colFechaLimite";
            this.colFechaLimite.Width = 100;
            //
            // colEstado
            //
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 80;
            //
            // colTituloDetalle
            //
            this.colTituloDetalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTituloDetalle.DataPropertyName = "Titulo";
            this.colTituloDetalle.HeaderText = "Libro";
            this.colTituloDetalle.Name = "colTituloDetalle";
            //
            // colCantidadDetalle
            //
            this.colCantidadDetalle.DataPropertyName = "Cantidad";
            this.colCantidadDetalle.HeaderText = "Cantidad";
            this.colCantidadDetalle.Name = "colCantidadDetalle";
            this.colCantidadDetalle.Width = 80;
            //
            // FrmPrestamos
            //
            this.ClientSize = new System.Drawing.Size(900, 590);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dtpFechaLimite);
            this.Controls.Add(this.dtpFechaPrestamo);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbLibro);
            this.Controls.Add(this.cmbAlumno);
            this.Controls.Add(this.lblDetalle);
            this.Controls.Add(this.lblPrestamosActivos);
            this.Controls.Add(this.lblFechaLimite);
            this.Controls.Add(this.lblFechaPrestamo);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblAlumno);
            this.Name = "FrmPrestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Préstamos";
            this.Load += new System.EventHandler(this.FrmPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
