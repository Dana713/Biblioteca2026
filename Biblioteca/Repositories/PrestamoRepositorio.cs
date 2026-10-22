using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Biblioteca.Interfaces;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public class PrestamoRepositorio : IPrestamo
    {
        public List<Prestamo> ObtenerTodos()
        {
            List<Prestamo> lista = new List<Prestamo>();

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT p.id, p.id_alumno, p.fecha_prestamo, p.fecha_limite, p.estado, " +
                                   "a.matricula, CONCAT(a.nombre, ' ', a.apellidos) AS alumno " +
                                   "FROM prestamos p " +
                                   "INNER JOIN alumnos a ON p.id_alumno = a.id " +
                                   "ORDER BY p.id DESC";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = comm.ExecuteReader();

                    using (dr)
                    {
                        while (dr.Read())
                        {
                            Prestamo prestamo = new Prestamo();

                            prestamo.ID = Convert.ToInt32(dr["id"].ToString());
                            prestamo.IDAlumno = Convert.ToInt32(dr["id_alumno"].ToString());
                            prestamo.FechaPrestamo = Convert.ToDateTime(dr["fecha_prestamo"].ToString());
                            prestamo.FechaLimite = Convert.ToDateTime(dr["fecha_limite"].ToString());
                            prestamo.Estado = dr["estado"].ToString();
                            prestamo.Matricula = dr["matricula"].ToString();
                            prestamo.NombreAlumno = dr["alumno"].ToString();

                            lista.Add(prestamo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new ErrorRepositorio().Registrar(ex, "Sin parametros");
                    throw;
                }
            }

            return lista;
        }

        public List<Prestamo> ObtenerActivos()
        {
            List<Prestamo> lista = new List<Prestamo>();

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT p.id, p.id_alumno, p.fecha_prestamo, p.fecha_limite, p.estado, " +
                                   "a.matricula, CONCAT(a.nombre, ' ', a.apellidos) AS alumno " +
                                   "FROM prestamos p " +
                                   "INNER JOIN alumnos a ON p.id_alumno = a.id " +
                                   "WHERE p.estado = 'Activo' " + // CORRECCIÓN: filtra préstamos activos, no devueltos.
                                   "ORDER BY p.id DESC";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = comm.ExecuteReader();

                    using (dr)
                    {
                        while (dr.Read())
                        {
                            Prestamo prestamo = new Prestamo();

                            prestamo.ID = Convert.ToInt32(dr["id"].ToString());
                            prestamo.IDAlumno = Convert.ToInt32(dr["id_alumno"].ToString());
                            prestamo.FechaPrestamo = Convert.ToDateTime(dr["fecha_prestamo"].ToString());
                            prestamo.FechaLimite = Convert.ToDateTime(dr["fecha_limite"].ToString()); // CORRECCIÓN: utiliza fecha_limite.
                            prestamo.Estado = dr["estado"].ToString();
                            prestamo.Matricula = dr["matricula"].ToString();
                            prestamo.NombreAlumno = dr["alumno"].ToString();

                            lista.Add(prestamo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new ErrorRepositorio().Registrar(ex, "Sin parametros");
                    throw;
                }
            }

            return lista;
        }

        public Prestamo Buscar(int id)
        {
            Prestamo prestamo = null;

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT p.id, p.id_alumno, p.fecha_prestamo, p.fecha_limite, p.estado, " +
                                   "a.matricula, CONCAT(a.nombre, ' ', a.apellidos) AS alumno " +
                                   "FROM prestamos p " +
                                   "INNER JOIN alumnos a ON p.id_alumno = a.id " +
                                   "WHERE p.id = @id";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@id", id);

                    MySqlDataReader dr = comm.ExecuteReader();

                    using (dr)
                    {
                        if (dr.Read())
                        {
                            prestamo = new Prestamo();

                            prestamo.ID = Convert.ToInt32(dr["id"].ToString());
                            prestamo.IDAlumno = Convert.ToInt32(dr["id_alumno"].ToString());
                            prestamo.FechaPrestamo = Convert.ToDateTime(dr["fecha_prestamo"].ToString());
                            prestamo.FechaLimite = Convert.ToDateTime(dr["fecha_limite"].ToString());
                            prestamo.Estado = dr["estado"].ToString();
                            prestamo.Matricula = dr["matricula"].ToString();
                            prestamo.NombreAlumno = dr["alumno"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    new ErrorRepositorio().Registrar(ex, "id=" + id);
                    throw;
                }
            }

            return prestamo;
        }

        public List<DetallePrestamo> ObtenerDetalles(int idPrestamo)
        {
            List<DetallePrestamo> lista = new List<DetallePrestamo>();

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT d.id, d.id_prestamo, d.id_libro, d.cantidad, l.titulo " +
                                   "FROM detalle_prestamo d " +
                                   "INNER JOIN libros l ON d.id_libro = l.id " +
                                   "WHERE d.id_prestamo = @id_prestamo ORDER BY d.id";

                    MySqlCommand comm = new MySqlCommand(query, conn);
                    comm.Parameters.AddWithValue("@id_prestamo", idPrestamo);

                    MySqlDataReader dr = comm.ExecuteReader();

                    using (dr)
                    {
                        while (dr.Read())
                        {
                            DetallePrestamo detalle = new DetallePrestamo();

                            detalle.ID = Convert.ToInt32(dr["id"].ToString());
                            detalle.IDPrestamo = Convert.ToInt32(dr["id_prestamo"].ToString());
                            detalle.IDLibro = Convert.ToInt32(dr["id_libro"].ToString());
                            detalle.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());
                            detalle.Titulo = dr["titulo"].ToString();

                            lista.Add(detalle);
                        }
                    }
                }
                catch (Exception ex)
                {
                    new ErrorRepositorio().Registrar(ex, "idPrestamo=" + idPrestamo);
                    throw;
                }
            }

            return lista;
        }

        public bool Registrar(Prestamo prestamo, List<DetallePrestamo> detalles)
        {
            // CORRECCIÓN: no permite préstamos sin alumno ni detalles.
            if (prestamo == null || detalles == null || detalles.Count == 0)
            {
                return false;
            }

            if (prestamo.IDAlumno <= 0)
            {
                return false;
            }

            // CORRECCIÓN: cada detalle debe tener un libro válido y una cantidad positiva.
            for (int i = 0; i < detalles.Count; i++)
            {
                if (detalles[i] == null ||
                    detalles[i].IDLibro <= 0 ||
                    detalles[i].Cantidad <= 0)
                {
                    return false;
                }
            }

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                MySqlTransaction trans = null;

                try
                {
                    conn.Open();

                    // CORRECCIÓN: todas las operaciones se ejecutan en una transacción.
                    trans = conn.BeginTransaction();

                    // Verifica que el alumno exista.
                    string queryAlumno = "SELECT COUNT(*) FROM alumnos WHERE id = @id_alumno";

                    using (MySqlCommand commAlumno = new MySqlCommand(queryAlumno, conn, trans))
                    {
                        commAlumno.Parameters.AddWithValue("@id_alumno", prestamo.IDAlumno);

                        int alumnoExiste = Convert.ToInt32(commAlumno.ExecuteScalar());

                        if (alumnoExiste == 0)
                        {
                            trans.Rollback();
                            return false;
                        }
                    }

                    // CORRECCIÓN: el nombre del parámetro coincide con @id_alumno.
                    string query = "INSERT INTO prestamos(id_alumno, fecha_prestamo, fecha_limite, estado) " +
                                   "VALUES(@id_alumno, @fecha_prestamo, @fecha_limite, 'Activo')";

                    using (MySqlCommand comm = new MySqlCommand(query, conn, trans))
                    {
                        comm.Parameters.AddWithValue("@id_alumno", prestamo.IDAlumno);
                        comm.Parameters.AddWithValue("@fecha_prestamo", prestamo.FechaPrestamo.Date);
                        comm.Parameters.AddWithValue("@fecha_limite", prestamo.FechaLimite.Date);

                        int filas = comm.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            trans.Rollback();
                            return false;
                        }
                    }

                    // Obtiene el identificador del préstamo recién insertado.
                    int idPrestamo;

                    using (MySqlCommand commID = new MySqlCommand(
                        "SELECT LAST_INSERT_ID()", conn, trans))
                    {
                        idPrestamo = Convert.ToInt32(commID.ExecuteScalar());
                    }

                    for (int i = 0; i < detalles.Count; i++)
                    {
                        DetallePrestamo detalle = detalles[i];

                        // CORRECCIÓN: descuenta la cantidad solicitada solo si hay existencias suficientes.
                        // La condición activo = 1 supone que libros tiene una columna activo.
                        string queryStock = "UPDATE libros " +
                                            "SET existencia = existencia - @cantidad " +
                                            "WHERE id = @id_libro AND activo = 1 " +
                                            "AND existencia >= @cantidad";

                        using (MySqlCommand commStock = new MySqlCommand(queryStock, conn, trans))
                        {
                            commStock.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                            commStock.Parameters.AddWithValue("@id_libro", detalle.IDLibro);

                            int stockActualizado = commStock.ExecuteNonQuery();

                            if (stockActualizado == 0)
                            {
                                // CORRECCIÓN: cancela todo si no hay suficientes ejemplares.
                                trans.Rollback();
                                return false;
                            }
                        }

                        string queryDetalle = "INSERT INTO detalle_prestamo(id_prestamo, id_libro, cantidad) " +
                                              "VALUES(@id_prestamo, @id_libro, @cantidad)";

                        using (MySqlCommand commDetalle = new MySqlCommand(queryDetalle, conn, trans))
                        {
                            commDetalle.Parameters.AddWithValue("@id_prestamo", idPrestamo);
                            commDetalle.Parameters.AddWithValue("@id_libro", detalle.IDLibro);
                            commDetalle.Parameters.AddWithValue("@cantidad", detalle.Cantidad);

                            commDetalle.ExecuteNonQuery();
                        }

                        detalle.IDPrestamo = idPrestamo;
                    }

                    // Confirma el préstamo, los detalles y el descuento de inventario juntos.
                    trans.Commit();

                    prestamo.ID = idPrestamo;

                    return true;
                }
                catch (Exception ex)
                {
                    // CORRECCIÓN: revierte las operaciones incompletas si ocurre un error.
                    if (trans != null)
                    {
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {

                        }
                    }

                    string parametros = "id_alumno=" + prestamo.IDAlumno +
                                         ", fecha_prestamo=" + prestamo.FechaPrestamo.Date +
                                         ", fecha_limite=" + prestamo.FechaLimite.Date +
                                         ", detalles_count=" + detalles.Count;

                    new ErrorRepositorio().Registrar(ex, parametros);
                    throw;
                }
                finally
                {
                    if (trans != null)
                    {
                        trans.Dispose();
                    }
                }
            }
        }

        public bool RegistrarDevolucion(int idPrestamo)
        {
            if (idPrestamo <= 0)
            {
                return false;
            }

            using (MySqlConnection conn = new MySqlConnection(Utils.connStr))
            {
                MySqlTransaction trans = null;

                try
                {
                    conn.Open();

                    // CORRECCIÓN: devolución e inventario se actualizan en una transacción.
                    trans = conn.BeginTransaction();

                    string queryPrestamo = "SELECT estado FROM prestamos " +
                                           "WHERE id = @id FOR UPDATE";

                    string estado;

                    using (MySqlCommand comm = new MySqlCommand(queryPrestamo, conn, trans))
                    {
                        comm.Parameters.AddWithValue("@id", idPrestamo);

                        object resultado = comm.ExecuteScalar();

                        if (resultado == null || resultado == DBNull.Value)
                        {
                            trans.Rollback();
                            return false;
                        }

                        estado = resultado.ToString();
                    }

                    // CORRECCIÓN: evita devolver dos veces el mismo préstamo.
                    if (estado != "Activo")
                    {
                        trans.Rollback();
                        return false;
                    }

                    List<DetallePrestamo> detalles = new List<DetallePrestamo>();

                    string queryDetalles = "SELECT id_libro, cantidad " +
                                           "FROM detalle_prestamo WHERE id_prestamo = @id_prestamo";

                    using (MySqlCommand comm = new MySqlCommand(queryDetalles, conn, trans))
                    {
                        comm.Parameters.AddWithValue("@id_prestamo", idPrestamo);

                        using (MySqlDataReader dr = comm.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                DetallePrestamo detalle = new DetallePrestamo();

                                detalle.IDLibro = Convert.ToInt32(dr["id_libro"].ToString());
                                detalle.Cantidad = Convert.ToInt32(dr["cantidad"].ToString());

                                detalles.Add(detalle);
                            }
                        }
                    }

                    if (detalles.Count == 0)
                    {
                        trans.Rollback();
                        return false;
                    }

                    for (int i = 0; i < detalles.Count; i++)
                    {
                        DetallePrestamo detalle = detalles[i];

                        // CORRECCIÓN: devuelve la cantidad registrada en el detalle.
                        string queryStock = "UPDATE libros " +
                                            "SET existencia = existencia + @cantidad " +
                                            "WHERE id = @id_libro";

                        using (MySqlCommand comm = new MySqlCommand(queryStock, conn, trans))
                        {
                            comm.Parameters.AddWithValue("@cantidad", detalle.Cantidad);
                            comm.Parameters.AddWithValue("@id_libro", detalle.IDLibro);

                            int filas = comm.ExecuteNonQuery();

                            if (filas == 0)
                            {
                                trans.Rollback();
                                return false;
                            }
                        }
                    }

                    // CORRECCIÓN: solo marca como devuelto un préstamo que estaba activo.
                    string queryDevolucion = "UPDATE prestamos " +
                                             "SET estado = 'Devuelto' " +
                                             "WHERE id = @id AND estado = 'Activo'";

                    using (MySqlCommand comm = new MySqlCommand(queryDevolucion, conn, trans))
                    {
                        comm.Parameters.AddWithValue("@id", idPrestamo);

                        int filas = comm.ExecuteNonQuery();

                        if (filas == 0)
                        {
                            trans.Rollback();
                            return false;
                        }
                    }

                    trans.Commit();

                    return true;
                }
                catch (Exception ex)
                {
                    if (trans != null)
                    {
                        try
                        {
                            trans.Rollback();
                        }
                        catch
                        {

                        }
                    }

                    new ErrorRepositorio().Registrar(ex, "idPrestamo=" + idPrestamo);
                    throw;
                }
                finally
                {
                    if (trans != null)
                    {
                        trans.Dispose();
                    }
                }
            }
        }
    }
}