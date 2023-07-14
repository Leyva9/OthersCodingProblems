using System.Diagnostics;
namespace AreaTrabajo {
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Crear un cronómetro
            Stopwatch crono = new Stopwatch();
            Console.Write("Por Favor Teclee su nombre: ");
            //Iniciar el cronómetro
            crono.Start();
            string? nombre = Console.ReadLine();
            //Parar el cronómetro
            crono.Stop();
            Console.WriteLine("Hola " + nombre + " , bienvenido a C Sharp");
            //Mostrando cuánto tiempo tomó escribir el nombre
            Console.WriteLine("Has demorado " + crono.Elapsed.Seconds + " segundos en escribir tu nombre");
        }
    }
}
