using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //while (true) {
            //    Console.WriteLine("Ingrese un numero entero: ");
            //    try
            //    {
            //        int numero = int.Parse(Console.ReadLine());
            //        if (numero % 2 == 0)
            //        {
            //            Console.WriteLine($"El numero {numero} es par.");
            //            continue;
            //        }
            //        else
            //        {
            //            Console.WriteLine($"El numero {numero} es impar.");
            //            continue;
            //        }
            //    }

            //    catch ( Exception e ) 
            //    {
            //        Console.WriteLine("ERROR 404");
            //           continue;
            //    }


            //    Console.ReadKey();}


            //float nota1, nota2, nota3, promedio;
            //Console.WriteLine("Ingrese la primera nota: ");
            //nota1 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la segunda nota: ");
            //nota2 = float.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese la tercera nota: ");
            //nota3 = float.Parse(Console.ReadLine());
            //if (nota1 < 1 || nota1 > 5 || nota2 < 1 || nota2 > 5 || nota3 < 1 || nota3 > 5)
            //{
            //    Console.WriteLine("Error: Las notas deben estar entre 1 y 5");
            //}
            //else
            //{
            //    promedio = ((nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f));
            //    if (promedio >= 3)
            //    {
            //        Console.WriteLine($"El estudiante aprobo con un promedio de: {promedio}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"El estudiante reprobo con un promedio de: {promedio}");
            //    }
            //}

            //    Console.ReadKey();}


            float precio;
            Console.WriteLine("Ingrese el precio del producto: ");
            precio = float.Parse(Console.ReadLine());
            if (precio >= 100000)
            {
                precio *= 0.8f;
                Console.WriteLine("Al producto se le aplica un descuento del 20%");
                Console.WriteLine($"El precio del producto es: ${precio}");
            }
            else
            {
                if (precio < 1)
                {
                    Console.WriteLine("Ingresa un valor valido");
                }
                else
                {
                    Console.WriteLine("El valor del producto no aplica a descuento");
                    Console.WriteLine($"El valor del producto es: ${precio}");
                }
            }



                Console.ReadKey();
            
            

        }
    }
}