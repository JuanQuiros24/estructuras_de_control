using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //----------- Array -----------

            //int[] numeros = new int[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Ingresa un Numero: {i + 1}");
            //    numeros[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Numero Ingresados: {i + 1}: {numeros[i]}");
            //}
            //Console.WriteLine("La suma es: " + numeros.Sum());

            //------------ Ejercicio Lista ----------------
            //List<int> numeros = new List<int>();
            //numeros.Add(10);
            //numeros.Add(20);
            //numeros.Add(30);

            //Console.WriteLine("Listas despues de añadir elementos");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            ////Acceder a un elementos por su indice
            //int primerElemento = numeros[1];
            //Console.WriteLine($"Primer elemento: {primerElemento}");

            ////modificar un elemento
            //numeros[1] = 25;
            //Console.WriteLine("Lista despues de modificar el segundo elemento:");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            //// Inserta un elemento en una posicion especifica
            //numeros.Insert(1, 15); // Insertar 15 en la posicion 1
            //Console.WriteLine("Lista despues de insertar 15 en la posicion 1:");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            // Eliminar un elemento especifico
            //numeros.Remove(30);
            //Console.WriteLine("Lista despues de eliminar el elemento 30:");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            //// Eliminar un elemento por posicion
            //numeros.RemoveAt(1);
            //Console.WriteLine("Lista despues de eliminar un elemento por la posicion");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}

            //// Ordenar la lista
            //numeros.Sort();
            //Console.WriteLine("Lista despues de ordenar: ");
            //foreach (int i in numeros)
            //{
            //    Console.WriteLine(i);
            //}


            // -------------Ejercicio--------------
            //List<string> productos = new List<string>();
            //List<decimal> precios = new List<decimal>();

            //while (true)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Menu de opciones:");
            //    Console.WriteLine("1. Agregar producto");
            //    Console.WriteLine("2. Mostrar productos");
            //    Console.WriteLine("3. Modificar producto");
            //    Console.WriteLine("4. Eliminar producto");
            //    Console.WriteLine("5. Salir");
            //    Console.Write("Seleccione una opción: ");

            //    string entrada = Console.ReadLine();
            //    if (!int.TryParse(entrada, out int opcion))
            //    {
            //        Console.WriteLine("Opción inválida. Intente de nuevo.");
            //        continue;
            //    }

            //    if (opcion == 1)
            //    {
            //        Console.Write("Agregar un producto (nombre): ");
            //        string producto = Console.ReadLine() ?? string.Empty;
            //        Console.Write("Agregar el precio: ");
            //        string precioStr = Console.ReadLine();
            //        if (!decimal.TryParse(precioStr, out decimal precio))
            //        {
            //            Console.WriteLine("Precio inválido. Operación cancelada.");
            //            continue;
            //        }

            //        productos.Add(producto);
            //        precios.Add(precio);
            //        Console.WriteLine("Producto agregado exitosamente.");
            //    }
            //    else if (opcion == 2)
            //    {
            //        Console.WriteLine("Lista de productos:");
            //        if (productos.Count == 0)
            //        {
            //            Console.WriteLine("(La lista está vacía)");
            //        }
            //        for (int i = 0; i < productos.Count; i++)
            //        {
            //            Console.WriteLine($"{i + 1}. {productos[i]} - ${precios[i]}");
            //        }
            //    }
            //    else if (opcion == 3)
            //    {
            //        Console.Write("Ingrese el nombre del producto a modificar (en minúsculas): ");
            //        string nombreBuscado = Console.ReadLine() ?? string.Empty;
            //        string nombreMinus = nombreBuscado.ToLower();

            //        int index = productos.FindIndex(p => (p ?? string.Empty).ToLower() == nombreMinus);
            //        if (index >= 0)
            //        {
            //            Console.Write("Ingrese el nuevo nombre del producto: ");
            //            string nuevoProducto = Console.ReadLine() ?? string.Empty;
            //            Console.Write("Ingrese el nuevo precio del producto: ");
            //            string nuevoPrecioStr = Console.ReadLine();
            //            if (!decimal.TryParse(nuevoPrecioStr, out decimal nuevoPrecio))
            //            {
            //                Console.WriteLine("Precio inválido. Operación cancelada.");
            //                continue;
            //            }

            //            productos[index] = nuevoProducto;
            //            precios[index] = nuevoPrecio;
            //            Console.WriteLine("Producto modificado exitosamente.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Producto no encontrado (asegúrese de escribir el nombre en minúsculas).");
            //        }
            //    }
            //    else if (opcion == 4)
            //    {
            //        Console.Write("Ingrese el nombre del producto a eliminar (en minúsculas): ");
            //        string nombreBuscado = Console.ReadLine() ?? string.Empty;
            //        string nombreMinus = nombreBuscado.ToLower();

            //        int index = productos.FindIndex(p => (p ?? string.Empty).ToLower() == nombreMinus);
            //        if (index >= 0)
            //        {
            //            productos.RemoveAt(index);
            //            precios.RemoveAt(index);
            //            Console.WriteLine("Producto eliminado exitosamente.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Producto no encontrado (asegúrese de escribir el nombre en minúsculas).");
            //        }
            //    }
            //    else if (opcion == 5)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opción no reconocida. Intente de nuevo.");
            //    }
            //}


            // --------------------- Casos de estudio POO (Modo de compatibilidad) ---------------------
            // --------------------- Ejercicio 1 ---------------------

            //Console.WriteLine("Ingresa la Marca del vehiculo N.1: ");
            //string ingresoMarca = Console.ReadLine();
            //Console.WriteLine("Ingresa el Modelo del vehiculo N.1: ");
            //string ingresoModelo = Console.ReadLine();
            //Vehiculo.Camion camion1 = new Vehiculo.Camion(ingresoMarca, ingresoModelo, 60000);

            //Console.WriteLine("Ingresa la Marca del vehiculo N.2: ");
            //string ingresoMarca2 = Console.ReadLine();
            //Console.WriteLine("Ingresa el Modelo del vehiculo N.2: ");
            //string ingresoModelo2 = Console.ReadLine();
            //Vehiculo.Camion camion2 = new Vehiculo.Camion(ingresoMarca2, ingresoModelo2, 10000);


            // --------------------- Ejercicio 2 ---------------------
            //Console.WriteLine("Ingresa el Nombre del Empleado N.1: ");
            //string ingresoNombre = Console.ReadLine();
            //Console.WriteLine("Ingresa el Cargo del Empleado N.1: ");
            //string ingresoCargo = Console.ReadLine();
            //Empleado empleado1 = new Empleado(ingresoNombre, ingresoCargo, 100000);

            //Console.WriteLine("Ingresa el Nombre del Empleado N.2: ");
            //string ingresoNombre2 = Console.ReadLine();
            //Console.WriteLine("Ingresa el Cargo del Empleado N.2: ");
            //string ingresoCargo2 = Console.ReadLine();
            //Empleado empleado2 = new Empleado(ingresoNombre2, ingresoCargo2, 100000);

            //Console.WriteLine("Ingresa el Nombre del Gerente N.1: ");
            //string ingresoNombreGerente = Console.ReadLine();
            //Empleado.Gerente gerente1 = new Empleado.Gerente(ingresoNombreGerente, 200000);

            //Console.WriteLine("Ingresa el Nombre del Gerente N.2: ");
            //string ingresoNombreGerente2 = Console.ReadLine();
            //Empleado.Gerente gerente2 = new Empleado.Gerente(ingresoNombreGerente2, 200000);

            //empleado1.MostrarInformacionEmpleado();
            //empleado2.MostrarInformacionEmpleado();
            //gerente1.MostrarInformacionEmpleado();
            //gerente2.MostrarInformacionEmpleado();



            // --------------------- Ejercicio 3 ---------------------

            List<Libro> biblioteca = new List<Libro>();

            Console.WriteLine("Bienvenido al sistema de Biblioteca Digital\n");

            Console.Write("¿Cuántos libros deseas registrar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                Console.WriteLine($"\nLibro #{i + 1}");
                Console.Write("¿Es un libro digital? (s/n): ");
                string tipo = Console.ReadLine().ToLower();

                Console.Write("Título: ");
                string titulo = Console.ReadLine();

                Console.Write("Autor: ");
                string autor = Console.ReadLine();

                Console.Write("Número de páginas: ");
                int paginas = int.Parse(Console.ReadLine());

                if (tipo == "s")
                {
                    Console.Write("Tamaño del archivo (MB): ");
                    double tamano = double.Parse(Console.ReadLine());

                    biblioteca.Add(new LibroDigital(titulo, autor, paginas, tamano));
                }
                else
                {
                    biblioteca.Add(new Libro(titulo, autor, paginas));
                }
            }

            Console.Clear();
            Console.WriteLine("Catálogo de libros registrados:\n");

            foreach (var libro in biblioteca)
            {
                if (libro is LibroDigital digital)
                {
                    Console.WriteLine(digital.MostrarResumen());
                }
                else
                {
                    Console.WriteLine($"Título: {libro.GetTitulo()} | Autor: {libro.GetAutor()} | Páginas: {libro.GetPaginas()}");
                }
            }

            Console.WriteLine("\n¿Deseas actualizar las páginas de algún libro? (s/n): ");
            string opcion = Console.ReadLine().ToLower();

            if (opcion == "s")
            {
                Console.Write("Título del libro a actualizar: ");
                string tituloBuscar = Console.ReadLine();

                foreach (var libro in biblioteca)
                {
                    if (libro.GetTitulo().Equals(tituloBuscar, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.Write("Nueva cantidad de páginas: ");
                        int nuevasPaginas = int.Parse(Console.ReadLine());
                        libro.ActualizarPaginasPersonal(nuevasPaginas);
                        Console.WriteLine("Páginas actualizadas correctamente.");
                    }
                }
            }

            Console.WriteLine("\nDatos finales de la biblioteca:\n");
            foreach (var libro in biblioteca)
            {
                if (libro is LibroDigital digital)
                {
                    Console.WriteLine(digital.MostrarResumen());
                }
                else
                {
                    Console.WriteLine($"Título: {libro.GetTitulo()} | Autor: {libro.GetAutor()} | Páginas: {libro.GetPaginas()}");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
