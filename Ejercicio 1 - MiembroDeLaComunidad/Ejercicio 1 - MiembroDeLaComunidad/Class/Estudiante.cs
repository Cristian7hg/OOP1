using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Estudiante : MiembroDeLaComunidad, Saludando
    {
        public string Matricula { get; set; }
        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un estudiante llamado {Nombre} y tengo {Edad} años.");
        }

    }
}
