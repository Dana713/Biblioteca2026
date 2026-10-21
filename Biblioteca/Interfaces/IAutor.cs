using System.Collections.Generic;
using Biblioteca.Models;

namespace Biblioteca.Interfaces
{
    public interface IAutor
    {
        List<Autor> ObtenerTodos();
        Autor Buscar(int id);
        bool Agregar(Autor autor);
        bool Modificar(Autor autor);
    }
}
