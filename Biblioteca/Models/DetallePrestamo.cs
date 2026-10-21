namespace Biblioteca.Models
{
    public class DetallePrestamo
    {
        public int ID { get; set; }
        public int IDPrestamo { get; set; }
        public int IDLibro { get; set; }
        public int Cantidad { get; set; }

        public string Titulo { get; set; }
    }
}
