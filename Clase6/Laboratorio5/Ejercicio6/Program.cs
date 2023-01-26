using System;
using System.Diagnostics.CodeAnalysis;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 6");
            int n = 1, suma = 0;

            while (n <= 10)
            {
                suma = n + suma;
                Console.WriteLine($"suma = {suma}");
                n++;

            }


            Console.ReadKey();
        }
    }
}
