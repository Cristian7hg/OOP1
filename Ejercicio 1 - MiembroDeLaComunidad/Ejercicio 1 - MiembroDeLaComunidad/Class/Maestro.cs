using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Maestro : Docente, Saludando
    {
        public string ProgramaEducativo { get; set; }
        public string HorarioDeClases { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un maestro llamado {Nombre} y tengo {Edad} años.");
        }

    }
}
