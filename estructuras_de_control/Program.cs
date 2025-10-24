using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace estructuras_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------- Ejercicio 1 ----------------

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

            // --------------- Ejercicio 2 ----------------

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

            // --------------- Ejercicio 3 ----------------

            //float precio;
            //Console.WriteLine("Ingrese el precio del producto: ");
            //precio = float.Parse(Console.ReadLine());
            //if (precio >= 100000)
            //{
            //    precio *= 0.8f;
            //    Console.WriteLine("Al producto se le aplica un descuento del 20%");
            //    Console.WriteLine($"El precio del producto es: ${precio}");
            //}
            //else
            //{
            //    if (precio < 1)
            //    {
            //        Console.WriteLine("Ingresa un valor valido");
            //    }
            //    else
            //    {
            //        Console.WriteLine("El valor del producto no aplica a descuento");
            //        Console.WriteLine($"El valor del producto es: ${precio}");
            //    }
            //}



            //    Console.ReadKey();



            // --------------- Ejercicio 4 ----------------

            //float montoPrestamo, interesAño, interesMes, prestamoTotal;
            //const float INTERES = 0.05f;

            //Console.WriteLine("Ingresa el monto del prestamo");
            //montoPrestamo = float.Parse(Console.ReadLine());

            //interesAño = INTERES * montoPrestamo;
            //Console.WriteLine($"Los intereses al año son: {interesAño}");

            //interesMes = ((INTERES * montoPrestamo) / 4) * 3 ;
            //Console.WriteLine($"Los intereses al tercer trimestre son: {interesMes}");

            //interesMes = (INTERES * montoPrestamo) / 12;
            //Console.WriteLine($"Los intereses al primer mes son: {interesMes}");

            //prestamoTotal = (((INTERES * montoPrestamo) * 5) + montoPrestamo);
            //Console.WriteLine($"El total pagado incluyendo los intereses es de: {prestamoTotal}");

            //Console.ReadKey();



            // --------------- Ejercicio 5 ----------------

            //float salarioEmpleado, ahorroMensual, salud, fondoPension, salarioTotal;
            //const float EPS = 0.125f;
            //const float PENSION = 0.16f;

            //Console.WriteLine("Ingresa el salario del empleado: ");
            //salarioEmpleado = float.Parse(Console.ReadLine());

            //Console.WriteLine("Ingresa el monto a ahorrar mensualmente: ");
            //ahorroMensual = float.Parse(Console.ReadLine());

            //salud = salarioEmpleado * EPS;
            //fondoPension = salarioEmpleado * PENSION;
            //salarioTotal = (salarioEmpleado + salud + fondoPension) - ahorroMensual;

            //Console.WriteLine($"Salario del empleado: {salarioEmpleado} ");
            //Console.WriteLine($"Ahorro programado mensualmente: {ahorroMensual} ");
            //Console.WriteLine($"Aporte a la salud (12.5%): {salud} ");
            //Console.WriteLine($"Aporte al fondo de pensiones: {fondoPension} ");
            //Console.WriteLine($"Total a recibir: {salarioTotal} ");



            // --------------- Ejercicio 6 ----------------
            // Inicio

            //Console.WriteLine("Bienvenido usuario por favor llena los siguientes datos: ");

            //// Datos Usuario Ingresar
            //Console.Write("Ingresa tu Nombre: ");
            //string nombreIngresado = Console.ReadLine();
            //Console.Write("Ingresa tu Edad: ");
            //int edadIngresada = int.Parse(Console.ReadLine());
            //Console.Write("Ingresa el Genero (m/f): ");
            //char generoIngresado = char.Parse(Console.ReadLine());
            //generoIngresado = char.ToUpper(generoIngresado);
            //if (generoIngresado == 'F' || generoIngresado == 'M')
            //{
            //    Console.Write("Ingresa tu Telefono: ");
            //    long telefonoIngresado = long.Parse(Console.ReadLine());

            //    Console.WriteLine("Se han ingresado los datos correctamente.");

            //    // Crear Objeto del Nuevo Usuario con sus Datos o Atributos

            //    Persona usuario1 = new Persona(nombreIngresado, edadIngresada, generoIngresado, telefonoIngresado);

            //    // Ciclo para el Switch
            //    bool continuar = true;
            //    while (continuar)
            //    {
            //        Console.WriteLine("Ingresa alguna de las siguientes opciones!" +
            //            "\n 1. Imprimir detalles del usuario." +
            //            "\n2. Calcular edad en dias." +
            //            "\n3. Modificar tu informacion." +
            //            "\n4. Salir del programa.");
            //        int opcion = int.Parse(Console.ReadLine());
            //        switch (opcion)
            //        {
            //            case 1:
            //                Console.WriteLine("Has escogido imprimir detalles de usuario");
            //                usuario1.DetallesUsuario();
            //                break;
            //            case 2:
            //                Console.WriteLine("Has escogido calcular edad en dias");
            //                usuario1.EdadUsuarioEnDias();
            //                break;
            //            case 3:
            //                Console.WriteLine("Has escogido modificar tu informacion de usuario");
            //                Console.Write("Ingresa tu nuevo nombre: ");
            //                string nombreIngresadoNuevo = Console.ReadLine();
            //                // Edad
            //                Console.Write("Ingresa tu nueva edad: ");
            //                int edadIngresadaNuevo = int.Parse(Console.ReadLine());
            //                // Telefono
            //                Console.Write("Ingresa tu nuevo telefono: ");
            //                long telefonoIngresadoNuevo = long.Parse(Console.ReadLine());

            //                //Modificacion
            //                usuario1._nombre = nombreIngresadoNuevo;
            //                usuario1._edad = edadIngresadaNuevo;
            //                usuario1._telefono = telefonoIngresadoNuevo;

            //                // Imprimir Nueva Info
            //                usuario1.EditarInformacionUsuario();
            //                break;
            //        }
            //        if (opcion == 4)
            //        {
            //            Console.WriteLine("Has salido del programa...");
            //            break;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error, Ingresa correctamente el genero debe ser 'F' o 'M'");
            //}


            // --------------- Ejercicio 7 ----------------

            //Libro.Biblioteca biblioteca = new Libro.Biblioteca();
            //bool continuar = true;
            //while (continuar)
            //{
            //    Console.WriteLine("Ingresa una opcion:");
            //    Console.WriteLine("1. Agregar libro");
            //    Console.WriteLine("2. Mostrar libros");
            //    Console.WriteLine("3. Salir del programa");
            //    int opcion = int.Parse(Console.ReadLine());
            //    switch (opcion)
            //    {
            //        case 1:
            //            Console.WriteLine("Escogiste la opcion agregar libros");
            //            biblioteca.AgregarLibro();
            //            break;
            //        case 2:
            //            Console.WriteLine("Escogiste la opcion mostrar libros");
            //            biblioteca.ListarLibros();
            //            break;
            //    }
            //    Console.WriteLine("Deseas Continuar? True (si) - False (no)");
            //    bool seguir = bool.Parse(Console.ReadLine());
            //    continuar = seguir;
            //    if (continuar == false)
            //    {
            //        Console.WriteLine("Has salido de la aplicacion.");
            //    }
            //}


            // --------------- Ejercicio 8 ----------------

            //int ingenieriaSistemas = 0, psicologia = 0, economia = 0, comunicacionSocial = 0, administracionEmpresas = 0;
            //int creditosTotales = 0;
            //decimal totalSinDescuento = 0, totalDescuento = 0, totalConDescuento = 0;
            //int ProgramaAcademico, MetodoPago;

            //const decimal valorCredito = 200000m;

            //while (true)
            //{
            //    Console.WriteLine(@"
            //Ingrese su programa académico:
            //1) Ingeniería de Sistemas
            //2) Psicología
            //3) Economía
            //4) Comunicación Social
            //5) Administración de Empresas
            //6) Salir
            //");
            //    ProgramaAcademico = int.Parse(Console.ReadLine());

            //    if (ProgramaAcademico == 6)
            //    {
            //        Console.WriteLine("Has salido del programa...");
            //        break;
            //    }

            //    int creditos = 0;
            //    decimal descuento = 0;

            //    switch (ProgramaAcademico)
            //    {
            //        case 1:
            //            creditos = 20;
            //            descuento = 0.18m;
            //            ingenieriaSistemas++;
            //            break;

            //        case 2:
            //            creditos = 16;
            //            descuento = 0.12m;
            //            psicologia++;
            //            break;

            //        case 3:
            //            creditos = 18;
            //            descuento = 0.10m;
            //            economia++;
            //            break;

            //        case 4:
            //            creditos = 18;
            //            descuento = 0.05m;
            //            comunicacionSocial++;
            //            break;

            //        case 5:
            //            creditos = 20;
            //            descuento = 0.15m;
            //            administracionEmpresas++;
            //            break;

            //        default:
            //            Console.WriteLine("Opción no válida, intenta nuevamente.");
            //            continue;
            //    }

            //    decimal precio = creditos * valorCredito;
            //    totalSinDescuento += precio;

            //    Console.WriteLine(@"
            //Seleccione su método de pago: 
            //1) Efectivo 
            //2) En línea
            //");
            //    MetodoPago = int.Parse(Console.ReadLine());

            //    if (MetodoPago == 1)
            //    {
            //        decimal descuentoAplicado = precio * descuento;
            //        precio -= descuentoAplicado;
            //        totalDescuento += descuentoAplicado;
            //    }

            //    Console.WriteLine($"El valor a pagar es de: ${precio:N0}");
            //    totalConDescuento += precio;
            //    creditosTotales += creditos;

            //    Console.WriteLine("Estudiante matriculado correctamente.\n");
            //}


            //Console.WriteLine("\n--- Resumen de inscripciones ---");
            //Console.WriteLine($"Ingeniería de Sistemas: {ingenieriaSistemas}");
            //Console.WriteLine($"Psicología: {psicologia}");
            //Console.WriteLine($"Economía: {economia}");
            //Console.WriteLine($"Comunicación Social: {comunicacionSocial}");
            //Console.WriteLine($"Administración de Empresas: {administracionEmpresas}");

            //Console.WriteLine($"\nTotal de créditos inscritos: {creditosTotales}");
            //Console.WriteLine($"Valor total sin descuentos: ${totalSinDescuento:N0}");
            //Console.WriteLine($"Total de descuentos aplicados: ${totalDescuento:N0}");
            //Console.WriteLine($"Valor neto pagado por los estudiantes: ${totalConDescuento:N0}");


            // --------------- Ejercicio 9 ----------------

            //const decimal PAGO_BASICO = 500000m;

            //Console.Write("Ingrese la cantidad de empleados: ");
            //int empleados = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= empleados; i++)
            //{
            //    Console.WriteLine($"\n=== Empleado #{i} ===");
            //    Console.Write("Ingrese la cantidad de ventas realizadas: ");
            //    int ventas = int.Parse(Console.ReadLine());

            //    int menoresIgual300 = 0;
            //    int entre300y800 = 0;
            //    int mayoresIgual800 = 0;
            //    decimal totalVentas = 0;

            //    for (int j = 1; j <= ventas; j++)
            //    {
            //        decimal valorVenta;

            //        do
            //        {
            //            Console.Write($"Ingrese el valor de la venta #{j}: ");
            //            valorVenta = decimal.Parse(Console.ReadLine());
            //            if (valorVenta <= 0)
            //                Console.WriteLine(" El valor debe ser positivo. Intente de nuevo.");
            //        } while (valorVenta <= 0);

            //        totalVentas += valorVenta;

            //        if (valorVenta <= 300000)
            //            menoresIgual300++;
            //        else if (valorVenta < 800000)
            //            entre300y800++;
            //        else
            //            mayoresIgual800++;
            //    }

            //    decimal porcentajeBono = 0;

            //    if (totalVentas >= 400000 && totalVentas <= 800000)
            //        porcentajeBono = 0.05m;
            //    else if (totalVentas > 800000)
            //        porcentajeBono = 0.10m;
            //    else if (totalVentas >= 400000)
            //        porcentajeBono = 0.03m;

            //    decimal bonificacion = totalVentas * porcentajeBono;
            //    decimal totalPagar = PAGO_BASICO + bonificacion;

            //    Console.WriteLine("\n--- Resultados del empleado ---");
            //    Console.WriteLine($"Ventas ≤ $300.000: {menoresIgual300}");
            //    Console.WriteLine($"Ventas entre $300.001 y $799.999: {entre300y800}");
            //    Console.WriteLine($"Ventas ≥ $800.000: {mayoresIgual800}");
            //    Console.WriteLine($"Monto total vendido: ${totalVentas:N0}");
            //    Console.WriteLine($"Bonificación: ${bonificacion:N0} ({porcentajeBono * 100}%)");
            //    Console.WriteLine($"Pago total (básico + bonificación): ${totalPagar:N0}");
            //    Console.WriteLine("------------------------------------");
            //}

            //Console.WriteLine("\n Proceso finalizado.");



            // --------------- Ejercicio 10 ----------------

            //int totalConductores = 0;
            //int menores30 = 0;
            //int masculinos = 0;
            //int femeninos = 0;
            //int masculinos12a30 = 0;
            //int fueraBogota = 0;

            //Console.Write("Ingrese la cantidad de conductores registrados: ");
            //int n = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"\n--- Conductor #{i} ---");

            //    int anioNacimiento;
            //    do
            //    {
            //        Console.Write("Ingrese el año de nacimiento: ");
            //        anioNacimiento = int.Parse(Console.ReadLine());
            //        if (anioNacimiento <= 1900 || anioNacimiento > DateTime.Now.Year)
            //            Console.WriteLine(" Año inválido. Intente nuevamente.");
            //    } while (anioNacimiento <= 1900 || anioNacimiento > DateTime.Now.Year);

            //    int edad = DateTime.Now.Year - anioNacimiento;

            //    int sexo;
            //    do
            //    {
            //        Console.Write("Ingrese el sexo (1: Femenino, 2: Masculino): ");
            //        sexo = int.Parse(Console.ReadLine());
            //        if (sexo != 1 && sexo != 2)
            //            Console.WriteLine("Opción inválida. Intente nuevamente.");
            //    } while (sexo != 1 && sexo != 2);

            //    int registro;
            //    do
            //    {
            //        Console.Write("Registro del carro (1: Bogotá, 2: Otras ciudades): ");
            //        registro = int.Parse(Console.ReadLine());
            //        if (registro != 1 && registro != 2)
            //            Console.WriteLine(" Opción inválida. Intente nuevamente.");
            //    } while (registro != 1 && registro != 2);

            //    totalConductores++;

            //    if (edad < 30)
            //        menores30++;

            //    if (sexo == 1)
            //        femeninos++;
            //    else
            //        masculinos++;

            //    if (sexo == 2 && edad >= 12 && edad <= 30)
            //        masculinos12a30++;

            //    if (registro == 2)
            //        fueraBogota++;
            //}

            //Console.WriteLine("\n--- Resultados Estadísticos ---");

            //Console.WriteLine($"Porcentaje de conductores menores de 30 años: {(menores30 * 100.0 / totalConductores):F2}%");
            //Console.WriteLine($"Porcentaje de conductores femeninos: {(femeninos * 100.0 / totalConductores):F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos: {(masculinos * 100.0 / totalConductores):F2}%");
            //Console.WriteLine($"Porcentaje de conductores masculinos entre 12 y 30 años: {(masculinos12a30 * 100.0 / totalConductores):F2}%");
            //Console.WriteLine($"Porcentaje de conductores con carros registrados fuera de Bogotá: {(fueraBogota * 100.0 / totalConductores):F2}%");

            //Console.WriteLine("\n Proceso finalizado. Presione cualquier tecla para salir...");
            //Console.ReadKey();


            // --------------- Ejercicio 11 ----------------

            //const decimal BONO = 150000m;
            //int anioActual = DateTime.Now.Year;

            //Console.Write("Ingrese la cantidad de empleados: ");
            //int n = int.Parse(Console.ReadLine());

            //int[] empleadosPorMes = new int[12];
            //int totalEmpleadosConBono = 0;
            //int sumaEdades = 0;

            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine($"\n--- Empleado #{i} ---");

            //    int dia, mes, anio;

            //    do
            //    {
            //        Console.Write("Ingrese el día de nacimiento (1-31): ");
            //        dia = int.Parse(Console.ReadLine());
            //        if (dia < 1 || dia > 31)
            //            Console.WriteLine(" Día inválido, intente nuevamente.");
            //    } while (dia < 1 || dia > 31);

            //    do
            //    {
            //        Console.Write("Ingrese el mes de nacimiento (1-12): ");
            //        mes = int.Parse(Console.ReadLine());
            //        if (mes < 1 || mes > 12)
            //            Console.WriteLine(" Mes inválido, intente nuevamente.");
            //    } while (mes < 1 || mes > 12);

            //    do
            //    {
            //        Console.Write("Ingrese el año de nacimiento: ");
            //        anio = int.Parse(Console.ReadLine());
            //        if (anio < 1900 || anio > anioActual)
            //            Console.WriteLine(" Año inválido, intente nuevamente.");
            //    } while (anio < 1900 || anio > anioActual);

            //    int edad = anioActual - anio;
            //    sumaEdades += edad;

            //    if (edad > 18 && edad < 50)
            //    {
            //        empleadosPorMes[mes - 1]++;
            //        totalEmpleadosConBono++;
            //    }
            //}

            //decimal totalBonos = totalEmpleadosConBono * BONO;
            //double promedioEdad = (double)sumaEdades / n;

            //Console.WriteLine("\n--- RESULTADOS ---");
            //Console.WriteLine($"Promedio de edad de los empleados: {promedioEdad:F2} años");
            //Console.WriteLine("\nMes\t\tEmpleados TikTok\tDinero en Bonos");

            //string[] meses = {
            //"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio",
            //"Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"
            //};

            //for (int i = 0; i < 12; i++)
            //{
            //    int empleadosMes = empleadosPorMes[i];
            //    decimal dineroMes = empleadosMes * BONO;

            //    if (empleadosMes > 0)
            //        Console.WriteLine($"{meses[i],-12} {empleadosMes,5} empleados\t\t${dineroMes:N0}");
            //    else
            //        Console.WriteLine($"{meses[i],-12} {empleadosMes,5} empleados\t\t$0");
            //}

            //Console.WriteLine($"\n Total de dinero a pagar por bonificaciones: ${totalBonos:N0}");
            //Console.WriteLine("\n Proceso finalizado. Presione cualquier tecla para salir...");
            //Console.ReadKey();


            // --------------- Ejercicio 12 ----------------

            const int totalCamiones = 20;
            int camionesCargados = 0;

            Console.WriteLine("--- Protocolo de carga de alcohol ---\n");

            while (camionesCargados < totalCamiones)
            {
                Console.WriteLine($"Camión #{camionesCargados + 1}");
                Console.Write("Ingrese la capacidad máxima del camión (18000 a 28000 litros): ");
                int capacidadCamion = int.Parse(Console.ReadLine());

                if (capacidadCamion < 18000 || capacidadCamion > 28000)
                {
                    Console.WriteLine("Capacidad fuera del rango permitido. Intente nuevamente.\n");
                    continue;
                }

                int cargaActual = 0;

                while (true)
                {
                    Console.Write("Ingrese el volumen de la saca (3000 a 9000 litros): ");
                    int saca = int.Parse(Console.ReadLine());

                    if (saca < 3000 || saca > 9000)
                    {
                        Console.WriteLine("Saca fuera del rango permitido. Intente nuevamente.\n");
                        continue;
                    }

                    if (cargaActual + saca > capacidadCamion)
                    {
                        Console.WriteLine($"No se puede cargar la saca. Se excedería la capacidad del camión ({cargaActual}/{capacidadCamion} litros).");
                        Console.WriteLine("Camión despachado.\n");
                        break;
                    }

                    cargaActual += saca;
                    Console.WriteLine($"Saca cargada. Carga actual: {cargaActual}/{capacidadCamion} litros.");

                    if (cargaActual == capacidadCamion)
                    {
                        Console.WriteLine("Camión cargado al máximo. Despachando...\n");
                        break;
                    }
                }

                camionesCargados++;
            }

            Console.WriteLine("Se han despachado los 20 camiones del día.");


        }
    }
}