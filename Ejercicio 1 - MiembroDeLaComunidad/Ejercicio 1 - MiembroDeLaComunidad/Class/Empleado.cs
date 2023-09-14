using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Empleado : MiembroDeLaComunidad, Saludando
    {
        public string ID { get; set; }
        public string Departamento { get; set;}
        public string Posicion { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un empleado llamado {Nombre} y tengo {Edad} años.");
        }
    }
}
