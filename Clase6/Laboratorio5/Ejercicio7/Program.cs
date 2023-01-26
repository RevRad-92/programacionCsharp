using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 7");
            int n = 1, suma = 0;

            while (n <= 25)
            {
                if (n % 2 == 0)
                {
                    suma = n + suma;
                }
                Console.WriteLine($"suma =       {suma}");
                n++;
            }

            Console.ReadKey();

        }
    }
}
