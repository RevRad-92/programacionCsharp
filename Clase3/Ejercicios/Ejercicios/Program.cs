using System;

namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Bonus 1");
            //Console.WriteLine("");

            //int n1 = 5, n2 = 10, n3 = 20;
            //Console.WriteLine($"n1 + n2 = {n1 + n2}");
            //Console.WriteLine($"n3 + n1 = {n3 - n1}");
            //Console.WriteLine($"n1 * n3 = {n1 * n3}");
            //Console.WriteLine($"n3 / n2 = {n3 / n2}");


            //Console.WriteLine("Bonus 2");
            //Console.WriteLine("");

            //int n1 = 10, n2 = 20, n3 = 30;
            //int total = n1 + n2 + n3;
            //double promedio = total / 3;
            //int resto = n2 % n1;

            //Console.WriteLine($"El total es {total}");
            //Console.WriteLine($"El promedio es {promedio}");
            //Console.WriteLine($"El resto entre n2 y n1 es {resto}");

            //Console.WriteLine("Bonus 3");
            //Console.WriteLine("");

            //bool n1 = true, n2 = false, n3 = true;
            //Console.WriteLine($"n1 ^ n2: {n1 ^ n2}");
            //Console.WriteLine($"(n1 & !n2) | n3: {(n1 & !n2) | n3}");
            //Console.WriteLine($"(n1 | n2) & !n3: {(n1 | n2) & n3}");

            //Console.WriteLine("Bonus 4");
            //Console.WriteLine("");

            //int n1 = 5, n2 = 10;
            //Console.WriteLine($"n1 es igual a {n1}, n2 es igual a {n2} y n1 más n2 es igual a {n1+n2}");

            Console.WriteLine("Bonus 5");
            Console.WriteLine("");

            const int IVA = 21;
            double remera = 59.90, pantalon = 99.90, campera = 149.90;
            Console.WriteLine($"Precio final remera: ${remera + remera * IVA / 100}");
            Console.WriteLine($"Precio final remera: ${pantalon + pantalon * IVA / 100}");
            Console.WriteLine($"Precio final remera: ${campera + campera * IVA / 100}");

            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadLine();
        }
    }
}
