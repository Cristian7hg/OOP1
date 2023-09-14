using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Administrador : Docente, ISaludando
    {
        public string Rol { get ; set; }
        public string Proyecto { get; set; }

        public override void Saludar()
        {
            Console.WriteLine($"Hola, soy un administrador llamado {Nombre} y tengo {Edad} años.");
        }
    }
}
