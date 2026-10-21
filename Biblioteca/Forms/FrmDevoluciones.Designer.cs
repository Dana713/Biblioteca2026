namespace Biblioteca.Forms
{
    partial class FrmDevoluciones
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblInfoAlumno;
        private System.Windows.Forms.Label lblInfoFechas;
        private System.Windows.Forms.Label lblInfoEstado;
        private System.Windows.Forms.Label lblPrestamosActivos;
        private System.Windows.Forms.Label lblDetalles;
        private System.Windows.Forms.TextBox txtIDPrestamo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridView dgvPrestamos;
        private System.Windows.Forms.DataGridView dgvDetalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIDPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatricula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAlumno;
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblInfoAlumno = new System.Windows.Forms.Label();
            this.lblInfoFechas = new System.Windows.Forms.Label();
            this.lblInfoEstado = new System.Windows.Forms.Label();
            this.lblPrestamosActivos = new System.Windows.Forms.Label();
            this.lblDetalles = new System.Windows.Forms.Label();
            this.txtIDPrestamo = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.dgvPrestamos = new System.Windows.Forms.DataGridView();
            this.dgvDetalles = new System.Windows.Forms.DataGridView();
            this.colIDPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatricula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTituloDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidadDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).BeginInit();
            this.SuspendLayout();
            //
            // lblID
            //
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(20, 25);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            //
            // lblInfoAlumno
            //
            this.lblInfoAlumno.AutoSize = true;
            this.lblInfoAlumno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblInfoAlumno.Location = new System.Drawing.Point(20, 60);
            this.lblInfoAlumno.Name = "lblInfoAlumno";
            this.lblInfoAlumno.Size = new System.Drawing.Size(58, 15);
            this.lblInfoAlumno.TabIndex = 1;
            this.lblInfoAlumno.Text = "Alumno: -";
            //
            // lblInfoFechas
            //
            this.lblInfoFechas.AutoSize = true;
            this.lblInfoFechas.Location = new System.Drawing.Point(20, 88);
            this.lblInfoFechas.Name = "lblInfoFechas";
            this.lblInfoFechas.Size = new System.Drawing.Size(93, 13);
            this.lblInfoFechas.TabIndex = 2;
            this.lblInfoFechas.Text = "Fechas: -";
            //
            // lblInfoEstado
            //
            this.lblInfoEstado.AutoSize = true;
            this.lblInfoEstado.Location = new System.Drawing.Point(20, 116);
            this.lblInfoEstado.Name = "lblInfoEstado";
            this.lblInfoEstado.Size = new System.Drawing.Size(55, 13);
            this.lblInfoEstado.TabIndex = 3;
            this.lblInfoEstado.Text = "Estado: -";
            //
            // lblPrestamosActivos
            //
            this.lblPrestamosActivos.AutoSize = true;
            this.lblPrestamosActivos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPrestamosActivos.Location = new System.Drawing.Point(20, 150);
            this.lblPrestamosActivos.Name = "lblPrestamosActivos";
            this.lblPrestamosActivos.Size = new System.Drawing.Size(109, 15);
            this.lblPrestamosActivos.TabIndex = 4;
            this.lblPrestamosActivos.Text = "Préstamos activos";
            //
            // lblDetalles
            //
            this.lblDetalles.AutoSize = true;
            this.lblDetalles.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDetalles.Location = new System.Drawing.Point(440, 150);
            this.lblDetalles.Name = "lblDetalles";
            this.lblDetalles.Size = new System.Drawing.Size(125, 15);
            this.lblDetalles.TabIndex = 5;
            this.lblDetalles.Text = "Detalle del préstamo";
            //
            // txtIDPrestamo
            //
            this.txtIDPrestamo.Location = new System.Drawing.Point(80, 22);
            this.txtIDPrestamo.Name = "txtIDPrestamo";
            this.txtIDPrestamo.Size = new System.Drawing.Size(80, 20);
            this.txtIDPrestamo.TabIndex = 6;
            //
            // btnBuscar
            //
            this.btnBuscar.Location = new System.Drawing.Point(180, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(110, 27);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar préstamo";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            //
            // btnDevolver
            //
            this.btnDevolver.Location = new System.Drawing.Point(300, 20);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(120, 27);
            this.btnDevolver.TabIndex = 8;
            this.btnDevolver.Text = "Registrar devolución";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(430, 20);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 27);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // dgvPrestamos
            //
            this.dgvPrestamos.AllowUserToAddRows = false;
            this.dgvPrestamos.AllowUserToDeleteRows = false;
            this.dgvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPrestamos.AutoGenerateColumns = false;
            this.dgvPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIDPrestamo,
            this.colMatricula,
            this.colNombreAlumno,
            this.colFechaLimite,
            this.colEstado});
            this.dgvPrestamos.Location = new System.Drawing.Point(20, 170);
            this.dgvPrestamos.MultiSelect = false;
            this.dgvPrestamos.Name = "dgvPrestamos";
            this.dgvPrestamos.ReadOnly = true;
            this.dgvPrestamos.RowHeadersVisible = false;
            this.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrestamos.Size = new System.Drawing.Size(400, 360);
            this.dgvPrestamos.TabIndex = 10;
            this.dgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPrestamos_CellClick);
            //
            // dgvDetalles
            //
            this.dgvDetalles.AllowUserToAddRows = false;
            this.dgvDetalles.AllowUserToDeleteRows = false;
            this.dgvDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalles.AutoGenerateColumns = false;
            this.dgvDetalles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTituloDetalle,
            this.colCantidadDetalle});
            this.dgvDetalles.Location = new System.Drawing.Point(440, 170);
            this.dgvDetalles.MultiSelect = false;
            this.dgvDetalles.Name = "dgvDetalles";
            this.dgvDetalles.ReadOnly = true;
            this.dgvDetalles.RowHeadersVisible = false;
            this.dgvDetalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalles.Size = new System.Drawing.Size(440, 360);
            this.dgvDetalles.TabIndex = 11;
            //
            // colIDPrestamo
            //
            this.colIDPrestamo.DataPropertyName = "ID";
            this.colIDPrestamo.HeaderText = "ID";
            this.colIDPrestamo.Name = "colIDPrestamo";
            this.colIDPrestamo.Width = 45;
            //
            // colMatricula
            //
            this.colMatricula.DataPropertyName = "Matricula";
            this.colMatricula.HeaderText = "Matrícula";
            this.colMatricula.Name = "colMatricula";
            this.colMatricula.Width = 75;
            //
            // colNombreAlumno
            //
            this.colNombreAlumno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombreAlumno.DataPropertyName = "NombreAlumno";
            this.colNombreAlumno.HeaderText = "Alumno";
            this.colNombreAlumno.Name = "colNombreAlumno";
            //
            // colFechaLimite
            //
            this.colFechaLimite.DataPropertyName = "FechaLimite";
            this.colFechaLimite.HeaderText = "Fecha límite";
            this.colFechaLimite.Name = "colFechaLimite";
            this.colFechaLimite.Width = 90;
            //
            // colEstado
            //
            this.colEstado.DataPropertyName = "Estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.Width = 70;
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
            // FrmDevoluciones
            //
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.dgvDetalles);
            this.Controls.Add(this.dgvPrestamos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtIDPrestamo);
            this.Controls.Add(this.lblDetalles);
            this.Controls.Add(this.lblPrestamosActivos);
            this.Controls.Add(this.lblInfoEstado);
            this.Controls.Add(this.lblInfoFechas);
            this.Controls.Add(this.lblInfoAlumno);
            this.Controls.Add(this.lblID);
            this.Name = "FrmDevoluciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Devoluciones";
            this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
