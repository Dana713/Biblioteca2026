namespace Biblioteca.Models
{
    public class Autor
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nacionalidad { get; set; }

        public string NombreCompleto
        {
            get { return Nombre + " " + Apellidos; }
        }
    }
}
