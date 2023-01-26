using System;

namespace Raices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //x = (-b +/- RAIZ (b^2 - 4ac)) / 2a        -->  4x2-2x+16

            double a = 0;
            double b = 0;
            double c = 0;
            string resultado = "";



            Console.WriteLine("Vamos a calcular las raices de su ecuación de segundo grado");

            Console.Write("Indicar coeficiente de Segundo grado:");
            a = Convert.ToDouble(Console.ReadLine());


            Console.Write("Indicar coeficiente de Primer Grado:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indicar el termino independiente:");
            c = Convert.ToDouble(Console.ReadLine());


            resultado=CalcularRaices(a, b, c);

            Console.WriteLine(resultado);



            Console.ReadKey();





        }


        static string CalcularRaices(double a, double b , double c)
        {

            //(-b +/- RAIZ(b ^ 2 - 4ac)) / 2a

            double raizPositiva = (-b + (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2*a) ;
            double raizNegativa = (-b - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            if (raizNegativa.ToString() == "NaN" || raizPositiva.ToString() == "NaN")
            {
                return "No hay raices reales";
            }else if (raizPositiva != raizNegativa)
            {
               return "Raiz Negativa:" + raizNegativa+"\n"+"Raiz Positiva:" + raizPositiva;


            }
            else
            {

                return "Hay una unica raiz:" + raizNegativa;
            }




          

        }

        //Ejemplo 3x2 -4x -2 =0 

    }
}
