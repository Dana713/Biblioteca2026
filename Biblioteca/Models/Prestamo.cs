using System;

namespace Biblioteca.Models
{
    public class Prestamo
    {
        public int ID { get; set; }
        public int IDAlumno { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaLimite { get; set; }
        public string Estado { get; set; }

        public string Matricula { get; set; }
        public string NombreAlumno { get; set; }

        public bool EstaActivo
        {
            get { return Estado == "Activo"; }
        }
    }
}
