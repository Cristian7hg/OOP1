using Ejercicio_1___MiembroDeLaComunidad.Class;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        ISaludando empleado = new Empleado();
        empleado.Saludar();

        ISaludando docente = new Docente();
        docente.Saludar();

        ISaludando maestro = new Maestro();
        maestro.Saludar();

        ISaludando estudiante = new Estudiante();
        estudiante.Saludar();


        Console.ReadKey();

    }
}