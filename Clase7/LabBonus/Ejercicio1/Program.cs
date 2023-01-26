using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            int n = 1;
            int suma = 0;

            while (n <= 30)
            {
                if (n % 2 == 0 && (n > 9 && n < 20) )
                {
                    suma += n;
                }
                n++;
                Console.WriteLine($"suma = {suma}");
            }


            Console.ReadLine();
        }
    }
}
