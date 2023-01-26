using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 7");

            for (int i = 1; i <= 5; i++)
            {

                if (i % 2 == 0)
                {
                    Console.WriteLine("@@");
                }
                else
                {
                    Console.WriteLine("@");
                }
            }


            Console.ReadKey();
        }
    }
}
