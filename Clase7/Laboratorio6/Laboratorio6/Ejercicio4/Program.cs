using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");
            int suma = 0;

            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    suma += i;
                    Console.WriteLine($"valor de suma = {suma}");

                }
            }


            Console.ReadKey();
        }
    }
}
