using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Libro
    {
        private string titulo;
        private string autor;
        private int paginas;

        public Libro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        // Métodos públicos para consultar los datos del libro
        public string GetTitulo()
        {
            return titulo;
        }

        public string GetAutor()
        {
            return autor;
        }

        public int GetPaginas()
        {
            return paginas;
        }

        private void ActualizarPaginas(int nuevasPaginas)
        {
            paginas = nuevasPaginas;
        }

        protected string GenerarResumen()
        {
            return $"\"{titulo}\" de {autor}, {paginas} páginas.";
        }

        public void ActualizarPaginasPersonal(int nuevasPaginas)
        {
            Console.WriteLine("Actualizando cantidad de páginas (solo personal autorizado)...");
            ActualizarPaginas(nuevasPaginas);
        }
    }

    class LibroDigital : Libro
    {
        private double tamanoArchivo; // en MB

        public LibroDigital(string titulo, string autor, int paginas, double tamanoArchivo)
            : base(titulo, autor, paginas)
        {
            this.tamanoArchivo = tamanoArchivo;
        }

        public string MostrarResumen()
        {
            string resumenBase = GenerarResumen();
            return $"{resumenBase} Tamaño del archivo: {tamanoArchivo} MB.";
        }

    }
}
