using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Models;
using Biblioteca.Repositories;

namespace Biblioteca.Forms
{
    public partial class FrmCategorias : Form
    {
        private int idSeleccionado = 0;

        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarTodos();
        }

        private void CargarTodos()
        {
            try
            {
                CategoriaRepositorio repo = new CategoriaRepositorio();
                List<Categoria> lista = repo.ObtenerTodos();

                dgvCategorias.DataSource = null;
                dgvCategorias.DataSource = lista;
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmCategorias; Metodo=CargarTodos");
                MessageBox.Show("Error al cargar categorías: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Categoria categoria = dgvCategorias.Rows[e.RowIndex].DataBoundItem as Categoria;

            if (categoria == null)
            {
                return;
            }

            idSeleccionado = categoria.ID;
            txtNombre.Text = categoria.Nombre;
            txtDescripcion.Text = categoria.Descripcion;
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtNombre.Clear();
            txtDescripcion.Clear();
            dgvCategorias.ClearSelection();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre es obligatorio.",
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Categoria categoria = new Categoria();

                categoria.Nombre = txtNombre.Text.Trim();
                categoria.Descripcion = txtDescripcion.Text.Trim();

                CategoriaRepositorio repo = new CategoriaRepositorio();

                if (repo.Agregar(categoria))
                {
                    MessageBox.Show("Categoría registrada correctamente.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la categoría.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmCategorias; Metodo=btnAgregar_Click");
                MessageBox.Show("Error al registrar categoría: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista.",
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El nombre es obligatorio.",
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Categoria categoria = new Categoria();

                categoria.ID = idSeleccionado;
                categoria.Nombre = txtNombre.Text.Trim();
                categoria.Descripcion = txtDescripcion.Text.Trim();

                CategoriaRepositorio repo = new CategoriaRepositorio();

                if (repo.Modificar(categoria))
                {
                    MessageBox.Show("Categoría modificada correctamente.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTodos();
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar la categoría.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmCategorias; Metodo=btnModificar_Click");
                MessageBox.Show("Error al modificar categoría: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarTodos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}