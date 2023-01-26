using System;

namespace Ejercicio1
{
    internal class Program
    {
        public enum Moneda
        {
            dolar = 1,
            peso // 2
        }

        public enum DolarHoy
        {
            valorDolar = 290

        }

        static void Main(string[] args)
        {

            Moneda moneda = 0;
            double importe = 0;
           
            Console.WriteLine("Ejercicio 1");


            Console.Write("Ingrese importe a convertir: ");
            importe = Convert.ToDouble(Console.ReadLine());

       
            do
            {

                Console.WriteLine("Indique tipo de moneda:\n1. Dólar\n2. Peso");
                moneda = (Moneda)Convert.ToInt32(Console.ReadLine());


                Convertir(DolarHoy.valorDolar, importe, moneda);


            } while (moneda > (Moneda)2 || moneda < (Moneda)1);
            

            Console.ReadKey();
        }

        // Metodos
        static double Convertir(DolarHoy valorDolar, double importe, Moneda moneda)
        {
            double resultado = 0;

            if (moneda.Equals(Moneda.dolar))
            {
                // convertir de dolar a pesos
                Console.WriteLine($"Convirtiendo USD{importe} a pesos...");
                resultado = importe * (double)valorDolar;
                Console.WriteLine($"USD{importe} = ${Math.Round(resultado)}");
                return resultado;


            }
            else if (moneda.Equals(Moneda.peso))
            {
                // convertir de peso a dolar
                Console.WriteLine($"Convirtiendo ${importe} a dólares...");
                resultado = importe / (double)valorDolar;
                Console.WriteLine($"${importe} = USD{Math.Round(resultado)}");
                return resultado;

            }
            else
            {
                Console.WriteLine("El tipo de moneda indicada es inexistente");
                return resultado;
            }




        }

      



    }
}
