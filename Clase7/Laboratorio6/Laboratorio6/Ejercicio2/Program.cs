using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            for (int i = 1; i <= 10; i=i+2)
            {
                Console.WriteLine($"valor de i = {i}");
            }


            Console.ReadKey();
        }
    }
}
