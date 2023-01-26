using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine($"n = {n}");
                n++;
            }

            Console.ReadKey();
        }
    }
}
