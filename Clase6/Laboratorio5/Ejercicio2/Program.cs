using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            int n = 1;

            while (n <= 10)
            {
                Console.WriteLine($"n = {n}");
                n = n + 2;
            }


            Console.ReadKey();
        }
    }
}
