using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicios
{
    internal class Libro
    {
        String Titulo;
        String Autor;
        String Estilo;
        String Editorial;
        public Libro(string titulo, string autor, string estilo, string editorial)
        {
            this.Titulo1 = titulo;
            this.Autor1 = autor;
            this.Estilo1 = estilo;
            this.Editorial1 = editorial;
        }

        public string Titulo1 { get => Titulo; set => Titulo = value; }
        public string Autor1 { get => Autor; set => Autor = value; }
        public string Estilo1 { get => Estilo; set => Estilo = value; }
        public string Editorial1 { get => Editorial; set => Editorial = value; }
    }
}