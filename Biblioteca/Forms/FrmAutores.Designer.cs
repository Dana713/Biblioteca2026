namespace Biblioteca.Forms
{
    partial class FrmAutores
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNacionalidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNacionalidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNacionalidad;

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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNacionalidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNacionalidad = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNacionalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            this.SuspendLayout();
            //
            // lblNombre
            //
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 25);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(52, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            //
            // lblApellidos
            //
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(350, 25);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(55, 13);
            this.lblApellidos.TabIndex = 1;
            this.lblApellidos.Text = "Apellidos:";
            //
            // lblNacionalidad
            //
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.Location = new System.Drawing.Point(20, 60);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(75, 13);
            this.lblNacionalidad.TabIndex = 2;
            this.lblNacionalidad.Text = "Nacionalidad:";
            //
            // txtNombre
            //
            this.txtNombre.Location = new System.Drawing.Point(120, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 3;
            //
            // txtApellidos
            //
            this.txtApellidos.Location = new System.Drawing.Point(450, 22);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(200, 20);
            this.txtApellidos.TabIndex = 4;
            //
            // txtNacionalidad
            //
            this.txtNacionalidad.Location = new System.Drawing.Point(120, 57);
            this.txtNacionalidad.Name = "txtNacionalidad";
            this.txtNacionalidad.Size = new System.Drawing.Size(200, 20);
            this.txtNacionalidad.TabIndex = 5;
            //
            // btnAgregar
            //
            this.btnAgregar.Location = new System.Drawing.Point(350, 55);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            //
            // btnModificar
            //
            this.btnModificar.Location = new System.Drawing.Point(480, 55);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 30);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(610, 55);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 30);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // btnMostrarTodos
            //
            this.btnMostrarTodos.Location = new System.Drawing.Point(350, 95);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(120, 30);
            this.btnMostrarTodos.TabIndex = 9;
            this.btnMostrarTodos.Text = "Mostrar todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            //
            // dgvAutores
            //
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutores.AutoGenerateColumns = false;
            this.dgvAutores.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNombre,
            this.colApellidos,
            this.colNacionalidad});
            this.dgvAutores.Location = new System.Drawing.Point(20, 140);
            this.dgvAutores.MultiSelect = false;
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.RowHeadersVisible = false;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(760, 330);
            this.dgvAutores.TabIndex = 10;
            this.dgvAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellClick);
            //
            // colNombre
            //
            this.colNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombre.DataPropertyName = "Nombre";
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            //
            // colApellidos
            //
            this.colApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellidos.DataPropertyName = "Apellidos";
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            //
            // colNacionalidad
            //
            this.colNacionalidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNacionalidad.DataPropertyName = "Nacionalidad";
            this.colNacionalidad.HeaderText = "Nacionalidad";
            this.colNacionalidad.Name = "colNacionalidad";
            //
            // FrmAutores
            //
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.dgvAutores);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNacionalidad);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNacionalidad);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmAutores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autores";
            this.Load += new System.EventHandler(this.FrmAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
