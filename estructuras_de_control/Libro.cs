using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_control
{
    internal class Libro
    {
        public int _id { get; set; }
        public string _titulo { get; set; }
        public string _autor { get; set; }
        public string _editorial { get; set; }
        public string _anioPublicacion { get; set; }

        public Libro(int id, string titulo, string autor, string editorial, string anioPublicacion)
        {
            _id = id;
            _titulo = titulo;
            _autor = autor;
            _editorial = editorial;
            _anioPublicacion = anioPublicacion;
        }
        // Clase Biblioteca
        public class Biblioteca
        {

            public List<Libro> LibrosLista = new List<Libro>();
            // Metodos
            public void AgregarLibro()
            {
                int siguienteId = 1;
                Console.WriteLine($"Ingresa el titulo del libro: ");
                string tituloLibro = Console.ReadLine();
                Console.WriteLine($"Ingresa el nombre del autor del libro: ");
                string autorLibro = Console.ReadLine();
                Console.WriteLine($"Ingresa la editorial del libro");
                string editorialLibro = Console.ReadLine();
                Console.WriteLine("Ingresa el Año de Publicacion del libro (DD/MM/AAAA): ");
                string anioPublicacionLibro = Console.ReadLine();
                Libro nuevoLibro = new Libro(siguienteId++, tituloLibro, autorLibro, editorialLibro, anioPublicacionLibro);
                LibrosLista.Add(nuevoLibro);
            }
            public void ListarLibros()
            {
                foreach (var libro in LibrosLista)
                {
                    Console.WriteLine($"ID: {libro._id}, Titulo: {libro._titulo}, Editorial libro:{libro._editorial},  Año de publicacion: {libro._anioPublicacion}");
                }
            }
        }
    }


}