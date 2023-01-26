using System;

namespace Ej2
{
    public enum Moneda
    {
        dolar = 350
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            double importe = 0;

            Console.WriteLine("Conversor");

            Console.Write("Ingrese importe a convertir: ");
            importe = Convert.ToDouble(Console.ReadLine());

            Console.Write("Convertir a:\n1. Dolar\n2. Peso");
            Console.ReadLine();

            Convertir(importe, Moneda.dolar);

        }

        static double Convertir(double importe, Moneda dolar)
        {

            return 1;
        }
    }
}
