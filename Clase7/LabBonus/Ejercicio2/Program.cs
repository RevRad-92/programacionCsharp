using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            int i = 0;
            int num = 0;
            int mayor = 0;
            int menor = 0;

            while (i < 5)
            {
                Console.Write("Ingrese un número: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > mayor)
                {
                    mayor = num;
                }

                if (num < menor)
                {
                    menor = num;
                }
                i++;
            }


            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");

            Console.ReadKey();

        }
    }
}
