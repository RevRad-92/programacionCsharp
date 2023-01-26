using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 5");
            int n = 1;

            while (n <= 30)
            {
                if (n <= 10 || n >= 20)
                {
                    Console.WriteLine($"n = {n}");
                }

                n++;    
            }


            Console.ReadKey();
        }
    }
}
