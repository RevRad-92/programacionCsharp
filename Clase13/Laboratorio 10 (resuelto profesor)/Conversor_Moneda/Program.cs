using System;

namespace Conversor_Moneda
{

    public enum Moneda
    {
        Peso = 1,
        Dolar = 2


    }




    internal class Program
    {


        static void Main(string[] args)
        {
            Moneda moneda = new Moneda();

            double cotizacion = 163;
            double monto = 0;
            double resultado = 0;


            Console.WriteLine("Bienvenido a Arbolito 3.0");

            Console.WriteLine("A que moneda desea convertir ?");


            Console.WriteLine("1. Peso\n2.Dolar");
            moneda = (Moneda)Convert.ToInt32(Console.ReadLine());


            Console.Beep();

            Console.Clear();

            Console.Write("Monto a convertir:");
            monto = Convert.ToInt32(Console.ReadLine());

            resultado = Convertir(monto, cotizacion, moneda);


            Console.WriteLine($"El monto resultante es: ${Math.Round(resultado, 2)} ");


            Console.ReadKey();







        }

        static double Convertir(double monto, double cotizacion, Moneda moneda)
        {

            if (moneda.Equals(Moneda.Peso)) // ==
            {

                return monto * cotizacion;

            }

            if (moneda.Equals(Moneda.Dolar))
            {

                Console.WriteLine("Se le estara descontando un 30%  Ley Dolar Solidario  + 35% Retención de ganancias anticipada");

                return (monto / (cotizacion * 1.65));


            }





            return 0;
        }





    }
}
