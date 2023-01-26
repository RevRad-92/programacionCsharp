using System;

namespace Funciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program programa = new Program();
            // double superficie = 0;
            bool resultado = false;

            Console.WriteLine("Funciones");

            //resultado = Funcion(); // error: no hay instancia para hacer el llamado. Funcion sin static
            resultado = programa.Funcion(); // llamado a funcion a través de instancia programa

            //superficie = SuperficieCirculo(5.5);
            Console.WriteLine($"El resultado es: {SuperficieCirculo(5.5)}");

            Console.ReadKey();
        }
        
        static double SuperficieCirculo(double radio)
        {
            Console.WriteLine("Calculando superficie...");
            double resultado = Math.PI * Math.Pow(radio, 2);
               
            return resultado; 
        }


        // sin static --> no hay instancia 
        bool Funcion()
        {
            return true;
        }

    }
}
