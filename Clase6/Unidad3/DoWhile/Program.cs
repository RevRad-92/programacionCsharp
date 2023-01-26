using System;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero = 10;
            Console.WriteLine("Do While");
            // me aseguro que al menos una vez se realice la acción

            do
            {

                Console.WriteLine("Número: {0}", numero);
                numero--;

            } 
            while (numero < 10 & numero > -15);

            Console.ReadKey();
            // if (true) Console.WriteLine("algo"); // valida pero no recomendable (llaves innecesarias.
        }

        
    }
}
