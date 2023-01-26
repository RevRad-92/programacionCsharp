using System;

namespace Eje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            double seguroA = 1000, seguroB = 600, seguroC = 200;
            int edad = 0;
            double seguro = 0;
            double cuota = 0;

            Console.WriteLine("Ingresar el seguro elegido: \n1. A ($1000)\n2. B ($600)\n3. C ($200)");
            Console.Write("Seguro elegido: ");
            seguro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            switch (seguro)
            {
                case 1:
                    seguro = seguroA;
                    break;
                case 2:
                    seguro = seguroB;
                    break;
                case 3:
                    seguro = seguroC;
                    break;
                default:
                    Console.WriteLine("La opción elegida es inexistente");
                    break;
            }

            if (edad < 22)
            {
                cuota = seguro * 1.35;

            } else if ( edad >= 22 && edad <= 30 )
            {
                cuota = seguro * 1.20;
            } else
            {
                cuota = seguro;
            }

            Console.WriteLine($"El costo de la cuota es: {cuota}");

            Console.ReadKey();

        }
    }
}
