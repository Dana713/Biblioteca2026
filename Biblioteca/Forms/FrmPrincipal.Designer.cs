namespace Biblioteca.Forms
{
    partial class FrmPrincipal
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuCatalogos;
        private System.Windows.Forms.ToolStripMenuItem menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem menuLibros;
        private System.Windows.Forms.ToolStripMenuItem menuAutores;
        private System.Windows.Forms.ToolStripMenuItem menuCategorias;
        private System.Windows.Forms.ToolStripMenuItem menuPrestamos;
        private System.Windows.Forms.ToolStripMenuItem menuPrestamosRegistrar;
        private System.Windows.Forms.ToolStripMenuItem menuDevoluciones;
        private System.Windows.Forms.ToolStripMenuItem menuSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnDevoluciones;

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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLibros = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrestamos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPrestamosRegistrar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDevoluciones = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnDevoluciones = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCatalogos,
            this.menuPrestamos,
            this.menuSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(700, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuCatalogos
            // 
            this.menuCatalogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAlumnos,
            this.menuLibros,
            this.menuAutores,
            this.menuCategorias});
            this.menuCatalogos.Name = "menuCatalogos";
            this.menuCatalogos.Size = new System.Drawing.Size(88, 24);
            this.menuCatalogos.Text = "Catálogos";
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(149, 24);
            this.menuAlumnos.Text = "Alumnos";
            this.menuAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // menuLibros
            // 
            this.menuLibros.Name = "menuLibros";
            this.menuLibros.Size = new System.Drawing.Size(149, 24);
            this.menuLibros.Text = "Libros";
            this.menuLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // menuAutores
            // 
            this.menuAutores.Name = "menuAutores";
            this.menuAutores.Size = new System.Drawing.Size(149, 24);
            this.menuAutores.Text = "Autores";
            this.menuAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // menuCategorias
            // 
            this.menuCategorias.Name = "menuCategorias";
            this.menuCategorias.Size = new System.Drawing.Size(149, 24);
            this.menuCategorias.Text = "Categorías";
            this.menuCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // menuPrestamos
            // 
            this.menuPrestamos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPrestamosRegistrar,
            this.menuDevoluciones});
            this.menuPrestamos.Name = "menuPrestamos";
            this.menuPrestamos.Size = new System.Drawing.Size(89, 24);
            this.menuPrestamos.Text = "Préstamos";
            // 
            // menuPrestamosRegistrar
            // 
            this.menuPrestamosRegistrar.Name = "menuPrestamosRegistrar";
            this.menuPrestamosRegistrar.Size = new System.Drawing.Size(204, 24);
            this.menuPrestamosRegistrar.Text = "Registrar préstamo";
            this.menuPrestamosRegistrar.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // menuDevoluciones
            // 
            this.menuDevoluciones.Name = "menuDevoluciones";
            this.menuDevoluciones.Size = new System.Drawing.Size(204, 24);
            this.menuDevoluciones.Text = "Devoluciones";
            this.menuDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // menuSalir
            // 
            this.menuSalir.Name = "menuSalir";
            this.menuSalir.Size = new System.Drawing.Size(50, 24);
            this.menuSalir.Text = "Salir";
            this.menuSalir.Click += new System.EventHandler(this.menuSalir_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(159, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(390, 37);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Sistema de Biblioteca Escolar";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitulo.Location = new System.Drawing.Point(198, 105);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(294, 19);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Administración de alumnos, libros y préstamos";
            this.lblSubtitulo.Click += new System.EventHandler(this.lblSubtitulo_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAlumnos.Location = new System.Drawing.Point(60, 160);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Size = new System.Drawing.Size(200, 55);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Text = "Alumnos";
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLibros.Location = new System.Drawing.Point(250, 160);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(200, 55);
            this.btnLibros.TabIndex = 4;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAutores.Location = new System.Drawing.Point(440, 160);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(200, 55);
            this.btnAutores.TabIndex = 5;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.Location = new System.Drawing.Point(60, 240);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(200, 55);
            this.btnCategorias.TabIndex = 6;
            this.btnCategorias.Text = "Categorías";
            this.btnCategorias.UseVisualStyleBackColor = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrestamos.Location = new System.Drawing.Point(250, 240);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(200, 55);
            this.btnPrestamos.TabIndex = 7;
            this.btnPrestamos.Text = "Préstamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnDevoluciones
            // 
            this.btnDevoluciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDevoluciones.Location = new System.Drawing.Point(440, 240);
            this.btnDevoluciones.Name = "btnDevoluciones";
            this.btnDevoluciones.Size = new System.Drawing.Size(200, 55);
            this.btnDevoluciones.TabIndex = 8;
            this.btnDevoluciones.Text = "Devoluciones";
            this.btnDevoluciones.UseVisualStyleBackColor = true;
            this.btnDevoluciones.Click += new System.EventHandler(this.btnDevoluciones_Click);
            // 
            // FrmPrincipal
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(700, 340);
            this.Controls.Add(this.btnDevoluciones);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnAlumnos);
            this.Controls.Add(this.lblSubtitulo);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Biblioteca Escolar";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
