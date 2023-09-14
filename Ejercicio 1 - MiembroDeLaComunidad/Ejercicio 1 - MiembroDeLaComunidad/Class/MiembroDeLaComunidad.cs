

namespace Ejercicio_1___MiembroDeLaComunidad.Class
{
    public abstract class MiembroDeLaComunidad : ISaludando
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Edad { get; set; }

        public virtual void Saludar()
        {
            Console.WriteLine($"Hola, soy {Nombre} y tengo {Edad} años.");
        }
    }
}
