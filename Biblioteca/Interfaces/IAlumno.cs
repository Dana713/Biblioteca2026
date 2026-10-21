using System.Collections.Generic;
using Biblioteca.Models;

namespace Biblioteca.Interfaces
{
    public interface IAlumno
    {
        List<Alumno> ObtenerTodos();
        List<Alumno> ObtenerActivos();
        List<Alumno> BuscarPorMatricula(string matricula);
        List<Alumno> BuscarPorNombre(string nombre);
        Alumno Buscar(int id);
        bool Agregar(Alumno alumno);
        bool Modificar(Alumno alumno);
        bool Desactivar(int id);
        bool ExisteMatricula(string matricula);
    }
}
