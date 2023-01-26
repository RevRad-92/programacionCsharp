using System;

namespace Laboratorio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");

            int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, mayor = 0;

            Console.WriteLine("Ingrese el primer número: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 >= mayor)
            {
                mayor = num1;
            }
            Console.WriteLine("Ingrese el segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 >= mayor)
            {
                mayor = num2;
            }
            Console.WriteLine("Ingrese el tercer número: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num3 >= mayor)
            {
                mayor = num3;
            }
            Console.WriteLine("Ingrese el cuarto número: ");
            num4 = Convert.ToInt32(Console.ReadLine());
            if (num4 >= mayor)
            {
                mayor = num4;
            }
            Console.WriteLine("Ingrese el quinto número: ");
            num5 = Convert.ToInt32(Console.ReadLine());
            if (num5 >= mayor)
            {
                mayor = num5;
            }

            Console.Write($"Los números ingresados son: {num1}, {num2}, {num3}, {num4}, {num5}\n");

            Console.WriteLine($"El número mayor es {mayor}");

            //if (num1 > num2 && num1 > num3 && num1 > num4 && num1 > num5)
            //{
            //    Console.WriteLine($"El número mayor es: {num1}");
            //} 
            //if (num2 > num1 && num2 > num3 && num2 > num4 && num2 > num5)
            //{
            //    Console.WriteLine($"El número mayor es: {num2}");

            //}
            //if (num3 > num1 && num3 > num2 && num3 > num4 && num3 > num5)
            //{
            //    Console.WriteLine($"El número mayor es: {num3}");

            //}
            //if (num4 > num1 && num4 > num2 && num4 > num3 && num4 > num5)
            //{
            //    Console.WriteLine($"El número mayor es: {num4}");

            //}
            //if (num5 > num1 && num5 > num2 && num5 > num3 && num5 > num4)
            //{
            //    Console.WriteLine($"El número mayor es: {num5}");

            //}

            

            Console.ReadKey();

        }
    }
}
