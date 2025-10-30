using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Vehiculo
    {
        private string _marca { get; set; }
        private string _modelo { get; set; }
        private double _kilometraje { get; set; }

        public Vehiculo(string marca, string modelo, double kilometraje)
        {
            _marca = marca;
            _modelo = modelo;
            _kilometraje = kilometraje;
        }

        // Herencia
        public class Camion : Vehiculo 
        {
            public Camion(string marca, string modelo, double kilometraje) : base(marca, modelo, kilometraje)
            {
            }
        }

        // Metodo protegido para calcular costo de mantenimiento segun el kilometraje
        protected double CalcularCostoMantenimiento()
        {
            if (_kilometraje < 10000)
            {
                return 100000;
            }
            else if (_kilometraje >= 10000 && _kilometraje < 50000)
            {
                return 200000;
            }
            else
            {
                return 350000;
            }
        }
        // Metodo protegido para mostrar la informacion del vehiculo
        public void MostrarInformacion()
        {
            Console.WriteLine($"Marca: {_marca}");
            Console.WriteLine($"Modelo: {_modelo}");
            Console.WriteLine($"Kilometraje: {_kilometraje} km");
            Console.WriteLine($"Costo de Mantenimiento: {CalcularCostoMantenimiento()}");
        }


    }
}
