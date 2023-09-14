using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class ExAlumno : MiembroDeLaComunidad, ISaludando
    {
        public string ExMatricula { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un ex alumno llamado {Nombre} y tengo {Edad} años.");
        }
    }
}
