using System;

namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For");
            int cantidadIteraciones = 0;

            // ( contador-inicializador-semilla ; condicion ; modificacion-post action )

            for (int i = 1; i <= 10; i++, cantidadIteraciones++)
            {
                // mis instrucciones

                if (i == 4)
                {
                    continue; // no imprime cuando i == 4
                }

                Console.WriteLine($"Valor de i: {i}");

                /*
                if (i == 5)
                {
                    break;
                }
                */

            }

            // Console.WriteLine(i); No existe, el alcance es solo dentro del for. 

            Console.WriteLine($"Cantidad de iteraciones: {cantidadIteraciones}");

            // While

            /*
            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine($"Valor de x: {x}");
                x++;
            }
            */



            Console.ReadKey();  
        }
    }
}
