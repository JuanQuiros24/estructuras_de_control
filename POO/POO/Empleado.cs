using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Empleado
    {
        private string _nombre { get; set; }
        private string _cargo { get; set; }
        private double _salario { get; set; }
        public Empleado(string nombre, string cargo, double salario)
        {
            _nombre = nombre;
            _cargo = cargo;
            _salario = salario;
        }

        // Herencia
        public class Gerente : Empleado
        {
            public Gerente(string nombre, double salario) : base(nombre, "Gerente", salario)
            {
            }
        }

        // Consultar salario
        protected double ConsultarSalario()
        {
            return _salario;
        }

        // Metodo protegido para calcular el bono segun el salario
        protected double CalcularBono()
        {
            if (_salario < 300000)
            {
                return (_salario * 0.10) + _salario;
            }
            else if (_salario >= 300000 && _salario < 700000)
            {
                return (_salario * 0.07) + _salario;
            }
            else
            {
                return (_salario * 0.05) + _salario;
            }
        }

        // Metodo protegido para mostrar la informacion del empleado
        public void MostrarInformacionEmpleado()
        {
            Console.WriteLine($"Nombre: {_nombre}");
            Console.WriteLine($"Cargo: {_cargo}");
            Console.WriteLine($"Salario mas bono: {CalcularBono()}");
        }

        

    }
}
