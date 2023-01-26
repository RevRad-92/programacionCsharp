using System;

namespace LecturaDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado = 0;

            Console.WriteLine("Hola, por favor ingresá un número");
            Console.Write("Número: "); // escribir en pantalla (input)

            numeroIngresado = Convert.ToInt32(Console.ReadLine()); // permite leer una linea

            Console.WriteLine($"Número ingresado: {numeroIngresado}");
            Console.ReadKey();
        }
    }
}
