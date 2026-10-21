using System;
using System.IO;
using System.Text;

namespace Biblioteca.Repositories
{
    public class ErrorRepositorio
    {
        private static readonly object bloqueo = new object();
        private static readonly Encoding utf8 = new UTF8Encoding(false);

        public void Registrar(Exception ex, string parametros)
        {
            try
            {
                string ruta = "errores.txt";
                string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                string hora = DateTime.Now.ToString("HH:mm:ss");
                string mensaje = Limpiar(ex.GetType().Name + ": " + ex.Message);
                string stackTrace = Limpiar(ex.StackTrace);
                string parametrosLimpios = Limpiar(parametros ?? "Sin parametros");

                lock (bloqueo)
                {
                    //si el archivo no existe lo crea con los encabezados
                    if (!File.Exists(ruta) || new FileInfo(ruta).Length == 0)
                    {
                        File.AppendAllText(ruta, "Fecha\tHora\tMensaje\tStackTrace\tParametros" + Environment.NewLine, utf8);
                    }

                    File.AppendAllText(ruta,
                        fecha + "\t" + hora + "\t" + mensaje + "\t" +
                        stackTrace + "\t" + parametrosLimpios + Environment.NewLine,
                        utf8);
                }
            }
            catch
            {
            }
        }

        //limpia el texto para que no rompa lo que se escribe en el archivo
        private string Limpiar(string texto)
        {
            if (string.IsNullOrEmpty(texto))
            {
                return "";
            }
            return texto.Replace("\r", " ").Replace("\n", " | ").Replace("\t", " ");
        }
    }
}