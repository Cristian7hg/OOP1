using Ejercicio_1___MiembroDeLaComunidad.Class;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Saludando empleado = new Empleado();
        empleado.Saludar();

        Saludando docente = new Docente();
        docente.Saludar();

        Saludando maestro = new Maestro();
        maestro.Saludar();

        Console.ReadKey();

    }
}