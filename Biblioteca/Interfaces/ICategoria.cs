using System.Collections.Generic;
using Biblioteca.Models;

namespace Biblioteca.Interfaces
{
    public interface ICategoria
    {
        List<Categoria> ObtenerTodos();
        Categoria Buscar(int id);
        bool Agregar(Categoria categoria);
        bool Modificar(Categoria categoria);
    }
}
