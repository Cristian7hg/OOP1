using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Administrativo : Empleado, Saludando
    {
        public string Puesto { get; set; }
        public string Horario { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un administrativo llamado {Nombre} y tengo {Edad} años.");
        }
    }
}
