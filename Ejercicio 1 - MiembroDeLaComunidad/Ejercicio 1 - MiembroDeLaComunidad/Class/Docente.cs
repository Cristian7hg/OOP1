using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Docente : Empleado, ISaludando
    {
        public string AsignaturaQueImparte { get; set; }
        public string GradoAcademico { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un docente llamado {Nombre} y tengo {Edad} años.");
        }

    }
}
