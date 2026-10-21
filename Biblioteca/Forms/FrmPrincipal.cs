using System;
using System.Windows.Forms;

namespace Biblioteca.Forms
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            FrmAlumnos formulario = new FrmAlumnos();
            formulario.ShowDialog();
        }

        private void btnLibros_Click(object sender, EventArgs e)
        {
            FrmLibros formulario = new FrmLibros();
            formulario.ShowDialog();
        }

        private void btnAutores_Click(object sender, EventArgs e)
        {
            FrmAutores formulario = new FrmAutores();
            formulario.ShowDialog();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            FrmCategorias formulario = new FrmCategorias();
            formulario.ShowDialog();
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos formulario = new FrmPrestamos();
            formulario.ShowDialog();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmDevoluciones formulario = new FrmDevoluciones();
            formulario.ShowDialog();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
