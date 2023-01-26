using System;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2");

            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto número: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el quinto número: ");
            num5 = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Los números ingresados son: {num1}, {num2}, {num3}, {num4}, {num5}\n");

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"El número {num1} es par");
            } else
            {
                Console.WriteLine($"El número {num1} es impar");
            }

            if (num2 % 2 == 0)
            {
                Console.WriteLine($"El número {num2} es par");
            }
            else
            {
                Console.WriteLine($"El número {num2} es impar");
            }

            if (num3 % 2 == 0)
            {
                Console.WriteLine($"El número {num3} es par");
            }
            else
            {
                Console.WriteLine($"El número {num3} es impar");
            }

            if (num4 % 2 == 0)
            {
                Console.WriteLine($"El número {num4} es par");
            }
            else
            {
                Console.WriteLine($"El número {num4} es impar");
            }

            if (num5 % 2 == 0)
            {
                Console.WriteLine($"El número {num5} es par");
            }
            else
            {
                Console.WriteLine($"El número {num5} es impar");
            }

            Console.ReadKey();
        }
    }
}
