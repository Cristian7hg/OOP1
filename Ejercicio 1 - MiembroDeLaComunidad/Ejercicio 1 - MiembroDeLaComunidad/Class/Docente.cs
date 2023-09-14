using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public class Docente : Empleado, Saludando
    {
        public string AsignaturaQueImparte { get; set; }
        public string GradoAcademico { get; set; }

    }
}
