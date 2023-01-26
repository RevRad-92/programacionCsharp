using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 8");
            string x = "";

            for (int i = 1; i <= 5; i++)
            {
                x = x + "@";
                Console.WriteLine($"{x}");
            }


            Console.ReadKey();
        }
    }
}
