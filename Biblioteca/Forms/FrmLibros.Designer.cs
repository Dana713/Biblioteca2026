namespace Biblioteca.Forms
{
    partial class FrmLibros
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblBuscarTitulo;
        private System.Windows.Forms.Label lblBuscarISBN;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.TextBox txtBuscarTitulo;
        private System.Windows.Forms.TextBox txtBuscarISBN;
        private System.Windows.Forms.ComboBox cmbAutor;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbFiltroCategoria;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscarTitulo;
        private System.Windows.Forms.Button btnBuscarISBN;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvLibros;
        private System.Windows.Forms.DataGridViewTextBoxColumn colISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExistencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colActivo;

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
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblBuscarTitulo = new System.Windows.Forms.Label();
            this.lblBuscarISBN = new System.Windows.Forms.Label();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtBuscarTitulo = new System.Windows.Forms.TextBox();
            this.txtBuscarISBN = new System.Windows.Forms.TextBox();
            this.cmbAutor = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbFiltroCategoria = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscarTitulo = new System.Windows.Forms.Button();
            this.btnBuscarISBN = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvLibros = new System.Windows.Forms.DataGridView();
            this.colISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExistencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).BeginInit();
            this.SuspendLayout();
            //
            // lblISBN
            //
            this.lblISBN.AutoSize = true;
            this.lblISBN.Location = new System.Drawing.Point(20, 25);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            //
            // lblTitulo
            //
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(350, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            //
            // lblExistencia
            //
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(20, 60);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(58, 13);
            this.lblExistencia.TabIndex = 2;
            this.lblExistencia.Text = "Existencia:";
            //
            // lblAutor
            //
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(350, 60);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(35, 13);
            this.lblAutor.TabIndex = 3;
            this.lblAutor.Text = "Autor:";
            //
            // lblCategoria
            //
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(20, 95);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(57, 13);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            //
            // lblBuscarTitulo
            //
            this.lblBuscarTitulo.AutoSize = true;
            this.lblBuscarTitulo.Location = new System.Drawing.Point(20, 173);
            this.lblBuscarTitulo.Name = "lblBuscarTitulo";
            this.lblBuscarTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblBuscarTitulo.TabIndex = 5;
            this.lblBuscarTitulo.Text = "Título:";
            //
            // lblBuscarISBN
            //
            this.lblBuscarISBN.AutoSize = true;
            this.lblBuscarISBN.Location = new System.Drawing.Point(450, 173);
            this.lblBuscarISBN.Name = "lblBuscarISBN";
            this.lblBuscarISBN.Size = new System.Drawing.Size(35, 13);
            this.lblBuscarISBN.TabIndex = 6;
            this.lblBuscarISBN.Text = "ISBN:";
            //
            // lblFiltro
            //
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(20, 213);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(57, 13);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Categoría:";
            //
            // txtISBN
            //
            this.txtISBN.Location = new System.Drawing.Point(130, 22);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(200, 20);
            this.txtISBN.TabIndex = 8;
            //
            // txtTitulo
            //
            this.txtTitulo.Location = new System.Drawing.Point(450, 22);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(300, 20);
            this.txtTitulo.TabIndex = 9;
            //
            // txtExistencia
            //
            this.txtExistencia.Location = new System.Drawing.Point(130, 57);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(80, 20);
            this.txtExistencia.TabIndex = 10;
            //
            // txtBuscarTitulo
            //
            this.txtBuscarTitulo.Location = new System.Drawing.Point(130, 170);
            this.txtBuscarTitulo.Name = "txtBuscarTitulo";
            this.txtBuscarTitulo.Size = new System.Drawing.Size(180, 20);
            this.txtBuscarTitulo.TabIndex = 11;
            //
            // txtBuscarISBN
            //
            this.txtBuscarISBN.Location = new System.Drawing.Point(540, 170);
            this.txtBuscarISBN.Name = "txtBuscarISBN";
            this.txtBuscarISBN.Size = new System.Drawing.Size(140, 20);
            this.txtBuscarISBN.TabIndex = 12;
            //
            // cmbAutor
            //
            this.cmbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAutor.FormattingEnabled = true;
            this.cmbAutor.Location = new System.Drawing.Point(450, 57);
            this.cmbAutor.Name = "cmbAutor";
            this.cmbAutor.Size = new System.Drawing.Size(300, 21);
            this.cmbAutor.TabIndex = 13;
            //
            // cmbCategoria
            //
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(130, 92);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbCategoria.TabIndex = 14;
            //
            // cmbFiltroCategoria
            //
            this.cmbFiltroCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltroCategoria.FormattingEnabled = true;
            this.cmbFiltroCategoria.Location = new System.Drawing.Point(130, 210);
            this.cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            this.cmbFiltroCategoria.Size = new System.Drawing.Size(200, 21);
            this.cmbFiltroCategoria.TabIndex = 15;
            //
            // chkActivo
            //
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(350, 94);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(57, 17);
            this.chkActivo.TabIndex = 16;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            //
            // btnAgregar
            //
            this.btnAgregar.Location = new System.Drawing.Point(20, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 30);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(140, 125);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(110, 30);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(260, 125);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(110, 30);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnBuscarTitulo
            //
            this.btnBuscarTitulo.Location = new System.Drawing.Point(320, 168);
            this.btnBuscarTitulo.Name = "btnBuscarTitulo";
            this.btnBuscarTitulo.Size = new System.Drawing.Size(110, 27);
            this.btnBuscarTitulo.TabIndex = 20;
            this.btnBuscarTitulo.Text = "Buscar título";
            this.btnBuscarTitulo.UseVisualStyleBackColor = true;
            this.btnBuscarTitulo.Click += new System.EventHandler(this.btnBuscarTitulo_Click);
            //
            // btnBuscarISBN
            //
            this.btnBuscarISBN.Location = new System.Drawing.Point(690, 168);
            this.btnBuscarISBN.Name = "btnBuscarISBN";
            this.btnBuscarISBN.Size = new System.Drawing.Size(110, 27);
            this.btnBuscarISBN.TabIndex = 21;
            this.btnBuscarISBN.Text = "Buscar ISBN";
            this.btnBuscarISBN.UseVisualStyleBackColor = true;
            this.btnBuscarISBN.Click += new System.EventHandler(this.btnBuscarISBN_Click);
            //
            // btnFiltrar
            //
            this.btnFiltrar.Location = new System.Drawing.Point(340, 208);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 27);
            this.btnFiltrar.TabIndex = 22;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            //
            // btnMostrarTodos
            //
            this.btnMostrarTodos.Location = new System.Drawing.Point(450, 208);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(130, 27);
            this.btnMostrarTodos.TabIndex = 23;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            //
            // dgvLibros
            //
            this.dgvLibros.AllowUserToAddRows = false;
            this.dgvLibros.AllowUserToDeleteRows = false;
            this.dgvLibros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLibros.AutoGenerateColumns = false;
            this.dgvLibros.BackgroundColor = System.Drawing.Color.White;
            this.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colISBN,
            this.colTitulo,
            this.colNombreAutor,
            this.colNombreCategoria,
            this.colExistencia,
            this.colActivo});
            this.dgvLibros.Location = new System.Drawing.Point(20, 255);
            this.dgvLibros.MultiSelect = false;
            this.dgvLibros.Name = "dgvLibros";
            this.dgvLibros.ReadOnly = true;
            this.dgvLibros.RowHeadersVisible = false;
            this.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibros.Size = new System.Drawing.Size(860, 320);
            this.dgvLibros.TabIndex = 24;
            this.dgvLibros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibros_CellClick);
            //
            // colISBN
            //
            this.colISBN.DataPropertyName = "ISBN";
            this.colISBN.HeaderText = "ISBN";
            this.colISBN.Name = "colISBN";
            this.colISBN.Width = 140;
            //
            // colTitulo
            //
            this.colTitulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTitulo.DataPropertyName = "Titulo";
            this.colTitulo.HeaderText = "Título";
            this.colTitulo.Name = "colTitulo";
            //
            // colNombreAutor
            //
            this.colNombreAutor.DataPropertyName = "NombreAutor";
            this.colNombreAutor.HeaderText = "Autor";
            this.colNombreAutor.Name = "colNombreAutor";
            this.colNombreAutor.Width = 150;
            //
            // colNombreCategoria
            //
            this.colNombreCategoria.DataPropertyName = "NombreCategoria";
            this.colNombreCategoria.HeaderText = "Categoría";
            this.colNombreCategoria.Name = "colNombreCategoria";
            this.colNombreCategoria.Width = 110;
            //
            // colExistencia
            //
            this.colExistencia.DataPropertyName = "Existencia";
            this.colExistencia.HeaderText = "Existencia";
            this.colExistencia.Name = "colExistencia";
            this.colExistencia.Width = 75;
            //
            // colActivo
            //
            this.colActivo.DataPropertyName = "Activo";
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.Width = 55;
            //
            // FrmLibros
            //
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.dgvLibros);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.btnBuscarISBN);
            this.Controls.Add(this.btnBuscarTitulo);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbFiltroCategoria);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbAutor);
            this.Controls.Add(this.txtBuscarISBN);
            this.Controls.Add(this.txtBuscarTitulo);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.lblBuscarISBN);
            this.Controls.Add(this.lblBuscarTitulo);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblExistencia);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblISBN);
            this.Name = "FrmLibros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
