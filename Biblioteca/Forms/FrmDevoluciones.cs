using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Models;
using Biblioteca.Repositories;

namespace Biblioteca.Forms
{
    public partial class FrmDevoluciones : Form
    {
        private int idPrestamoActual = 0;

        public FrmDevoluciones()
        {
            InitializeComponent();
        }

        private void FrmDevoluciones_Load(object sender, EventArgs e)
        {
            CargarPrestamosActivos();
        }

        private void CargarPrestamosActivos()
        {
            try
            {
                PrestamoRepositorio repo = new PrestamoRepositorio();
                List<Prestamo> lista = repo.ObtenerActivos();

                dgvPrestamos.DataSource = null;
                dgvPrestamos.DataSource = lista;
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmDevoluciones; Metodo=CargarPrestamosActivos");
                MessageBox.Show("Error al cargar préstamos: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarPrestamo(int id)
        {
            try
            {
                PrestamoRepositorio repo = new PrestamoRepositorio();
                Prestamo prestamo = repo.Buscar(id);

                if (prestamo == null)
                {
                    idPrestamoActual = 0;
                    lblInfoAlumno.Text = "Alumno: -";
                    lblInfoFechas.Text = "Fechas: -";
                    lblInfoEstado.Text = "Estado: -";
                    dgvDetalles.DataSource = null;

                    MessageBox.Show("No se encontró el préstamo indicado.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                idPrestamoActual = prestamo.ID;

                lblInfoAlumno.Text = "Alumno: " + prestamo.Matricula + " - " +
                                     prestamo.NombreAlumno;
                lblInfoFechas.Text = "Fechas: préstamo " +
                                     prestamo.FechaPrestamo.ToString("dd/MM/yyyy") +
                                     " | límite " +
                                     prestamo.FechaLimite.ToString("dd/MM/yyyy");
                lblInfoEstado.Text = "Estado: " + prestamo.Estado;

                List<DetallePrestamo> detalles = repo.ObtenerDetalles(prestamo.ID);

                dgvDetalles.DataSource = null;
                dgvDetalles.DataSource = detalles;
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmDevoluciones; Metodo=CargarPrestamo");
                MessageBox.Show("Error al consultar el préstamo: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPrestamos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            Prestamo prestamo = dgvPrestamos.Rows[e.RowIndex].DataBoundItem as Prestamo;

            if (prestamo == null)
            {
                return;
            }

            txtIDPrestamo.Text = prestamo.ID.ToString();

            CargarPrestamo(prestamo.ID);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtIDPrestamo.Text.Trim() == "")
            {
                MessageBox.Show("Escriba el ID del préstamo.",
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtIDPrestamo.Text.Trim());

                CargarPrestamo(id);
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmDevoluciones; Metodo=btnBuscar_Click");
                MessageBox.Show("Error al buscar el préstamo: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (idPrestamoActual == 0)
            {
                MessageBox.Show("Busque o seleccione un préstamo.",
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PrestamoRepositorio repo = new PrestamoRepositorio();

                if (repo.RegistrarDevolucion(idPrestamoActual))
                {
                    MessageBox.Show("Devolución registrada correctamente.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CargarPrestamosActivos();
                    CargarPrestamo(idPrestamoActual);
                }
                else
                {
                    MessageBox.Show("No se pudo registrar la devolución. " +
                        "El préstamo no existe o ya fue devuelto.",
                        "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Formulario=FrmDevoluciones; Metodo=btnDevolver_Click");
                MessageBox.Show("Error al registrar la devolución: " + ex.Message,
                    "Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            idPrestamoActual = 0;
            txtIDPrestamo.Clear();
            lblInfoAlumno.Text = "Alumno: -";
            lblInfoFechas.Text = "Fechas: -";
            lblInfoEstado.Text = "Estado: -";
            dgvDetalles.DataSource = null;
            dgvPrestamos.ClearSelection();
        }
    }
}