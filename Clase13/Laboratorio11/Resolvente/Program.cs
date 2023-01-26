using System;

namespace Resolvente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fórmula Resolvente");

            double a = 0, b = 0, c = 0;
            string resultado;

            Console.WriteLine("Ingresá a, b y c");
            Console.Write($"Ingresá el valor de a: "); // coeficiente de segundo grado
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Ingresá el valor de b: "); // coeficiente de primer grado
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Ingresá el valor de c: "); // coeficiente independiente
            c = Convert.ToDouble(Console.ReadLine()); 

            resultado = Resolvente(a, b, c);
            Console.WriteLine(resultado);


            Console.ReadKey();

        }

        static string Resolvente(double a, double b, double c)
        {
            

            // raiz positiva
            double RaizPositiva = ((-b) + (Math.Sqrt(Math.Pow(b,2) - 4 * a * c))) / (2 * a);

            // raiz negativa
            double RaizNegativa = ((-b) - (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c))) / (2 * a);

            if (RaizNegativa.ToString() == "Nan" || RaizPositiva.ToString() == "NaN")
            {
                // no hay raices reales
                return "No hay raices reales";
            } else if (RaizPositiva != RaizNegativa)
            {
                return "Raiz Negativa: " + RaizNegativa+"\n"+"Raiz Positiva:" + RaizPositiva;
            } else
            {
                return "Raíz única: " + RaizPositiva;
            }

            

           
        }
    }
}
