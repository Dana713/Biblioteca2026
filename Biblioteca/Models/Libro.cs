namespace Biblioteca.Models
{
    public class Libro
    {
        public int ID { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public int IDAutor { get; set; }
        public int IDCategoria { get; set; }
        public int Existencia { get; set; }
        public bool Activo { get; set; }

        public string NombreAutor { get; set; }
        public string NombreCategoria { get; set; }

        public bool Disponible
        {
            get { return Activo && Existencia > 0; }
        }
    }
}
