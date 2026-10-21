using System.Collections.Generic;
using Biblioteca.Models;

namespace Biblioteca.Interfaces
{
    public interface IPrestamo
    {
        List<Prestamo> ObtenerTodos();
        List<Prestamo> ObtenerActivos();
        Prestamo Buscar(int id);
        List<DetallePrestamo> ObtenerDetalles(int idPrestamo);
        bool Registrar(Prestamo prestamo, List<DetallePrestamo> detalles);
        bool RegistrarDevolucion(int idPrestamo);
    }
}
