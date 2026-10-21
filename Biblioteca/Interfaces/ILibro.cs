using System.Collections.Generic;
using Biblioteca.Models;

namespace Biblioteca.Interfaces
{
    public interface ILibro
    {
        List<Libro> ObtenerTodos();
        List<Libro> ObtenerDisponibles();
        List<Libro> BuscarPorTitulo(string titulo);
        List<Libro> BuscarPorISBN(string isbn);
        List<Libro> FiltrarPorCategoria(int idCategoria);
        Libro Buscar(int id);
        bool Agregar(Libro libro);
        bool Modificar(Libro libro);
        bool ExisteISBN(string isbn);
        bool DisminuirExistencia(int idLibro, int cantidad);
        bool AumentarExistencia(int idLibro, int cantidad);
    }
}
