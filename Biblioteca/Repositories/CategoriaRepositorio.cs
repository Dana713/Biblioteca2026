using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Biblioteca.Interfaces;
using Biblioteca.Models;

namespace Biblioteca.Repositories
{
    public class CategoriaRepositorio : ICategoria
    {
        public List<Categoria> ObtenerTodos()
        {
            List<Categoria> lista = new List<Categoria>();

            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            try
            {
                conn.Open();

                string query = "SELECT * FROM categorias ORDER BY nombre";

                MySqlCommand comm = new MySqlCommand(query, conn);
                MySqlDataReader dr = comm.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Categoria categoria = new Categoria();

                        categoria.ID = Convert.ToInt32(dr["id"].ToString());
                        categoria.Nombre = dr["nombre"].ToString();
                        categoria.Descripcion = dr["descripcion"].ToString();

                        lista.Add(categoria);
                    }
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "Sin parametros");
                throw;
            }
            finally
            {
                conn.Close();
            }

            return lista;
        }

        public Categoria Buscar(int id)
        {
            Categoria categoria = null;

            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            try
            {
                conn.Open();

                string query = "SELECT * FROM categorias WHERE id = @id";

                MySqlCommand comm = new MySqlCommand(query, conn);
                comm.Parameters.AddWithValue("@id", id);

                MySqlDataReader dr = comm.ExecuteReader();

                if (dr.Read())
                {
                    categoria = new Categoria();

                    categoria.ID = Convert.ToInt32(dr["id"].ToString());
                    categoria.Nombre = dr["nombre"].ToString();
                    categoria.Descripcion = dr["descripcion"].ToString();
                }

                dr.Close();
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "id=" + id);
                throw;
            }
            finally
            {
                conn.Close();
            }

            return categoria;
        }

        public bool Agregar(Categoria categoria)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            try
            {
                conn.Open();

                string query = "INSERT INTO categorias(nombre, descripcion) " +
                               "VALUES(@nombre, @descripcion)";

                MySqlCommand comm = new MySqlCommand(query, conn);

                comm.Parameters.AddWithValue("@nombre", categoria.Nombre);
                comm.Parameters.AddWithValue("@descripcion", categoria.Descripcion);

                int filas = comm.ExecuteNonQuery();

                return filas > 0;
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "nombre=" + categoria.Nombre + ", descripcion=" + categoria.Descripcion);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        public bool Modificar(Categoria categoria)
        {
            MySqlConnection conn = new MySqlConnection(Utils.connStr);
            try
            {
                conn.Open();

                string query = "UPDATE categorias SET nombre = @nombre, " +
                               "descripcion = @descripcion WHERE id = @id";

                MySqlCommand comm = new MySqlCommand(query, conn);

                comm.Parameters.AddWithValue("@nombre", categoria.Nombre);
                comm.Parameters.AddWithValue("@descripcion", categoria.Descripcion);
                comm.Parameters.AddWithValue("@id", categoria.ID);

                int filas = comm.ExecuteNonQuery();

                return filas > 0;
            }
            catch (Exception ex)
            {
                new ErrorRepositorio().Registrar(ex, "id=" + categoria.ID + ", nombre=" + categoria.Nombre + ", descripcion=" + categoria.Descripcion);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}