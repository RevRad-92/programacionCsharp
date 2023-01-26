using System;
using System.ComponentModel;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");
            int n = 10;

            while (n >= 1)
            {
                Console.WriteLine($"n = {n}");
                n--;
            }
            Console.ReadKey();
        }
    }
}
