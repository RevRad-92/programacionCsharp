using System;

namespace Eje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");
            double seguroA = 1000, seguroB = 600, seguroC = 200;
            int edad = 0;
            double seguro1 = 0;
            double seguro2 = 0;
            double cuota = 0;

            Console.WriteLine("Ingresar primer seguro: \n1. A ($1000)\n2. B ($600)\n3. C ($200)");
            Console.Write("Primer seguro elegido: ");
            seguro1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar segundo seguro: \n1. A ($1000)\n2. B ($600)\n3. C ($200)\n4. Ninguno");
            Console.Write("Segundo seguro elegido: ");
            seguro2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar edad: ");
            edad = Convert.ToInt32(Console.ReadLine());

            switch (seguro1)
            {
                case 1:
                    seguro1 = seguroA;
                    break;
                case 2:
                    seguro1 = seguroB;
                    break;
                case 3:
                    seguro1 = seguroC;
                    break;
                default:
                    Console.WriteLine("La opción elegida es inexistente");
                    break;
            }

            switch (seguro2)
            {
                case 1:
                    seguro2 = seguroA;
                    break;
                case 2:
                    seguro2 = seguroB;
                    break;
                case 3:
                    seguro2 = seguroB;
                    break;
                case 4:
                    seguro2 = 0;
                    break;
                default:
                    Console.WriteLine("La opción elegida es inexistente");
                    break;
            }

            if (edad < 22)
            {
                cuota = (seguro1 + seguro2) * 1.35;

            }
            else if (edad >= 22 && edad <= 30)
            {
                cuota = (seguro1 + seguro2) * 1.20;
            }

            Console.WriteLine($"El costo de la cuota es: {cuota}");

            Console.ReadKey();
        }
    }
}
