namespace Biblioteca.Models
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Carrera { get; set; }
        public bool Activo { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }
    }
}
