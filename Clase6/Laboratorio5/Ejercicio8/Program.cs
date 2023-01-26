using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 8");
            int n = -10, multi = 1;

            while (n <= 10)
            {
                if (n % 2 != 0)
                {
                    multi = n * multi;
                }
                Console.WriteLine($"multi = {multi}"); 
                n++;
            }



            Console.ReadKey();
        }
    }
}
