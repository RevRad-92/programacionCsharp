using System;

namespace Estructura_If
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 10;
            bool principioDeMes = true;
            bool finDeSemana = true;

            Console.WriteLine("Condicionales");

            // if simple

            Console.WriteLine("If simple");

            if ( (var1 == var2) & (var1 == 10))
            {
                // se ejecuta si la condición es true
                Console.WriteLine("El valor de ambas variables es el mismo");
            }

            // if else
            Console.WriteLine("If Else");

            if (var1 != var2 )
            {
                // se ejecuta si la condición es true
                Console.WriteLine("El valor de ambas variables son distintas");
            } else
            {
                Console.WriteLine("Ambas variables son iguales");
            }

            // if anidado

            Console.WriteLine("If anidado");

            if ( principioDeMes )
            {
                if ( finDeSemana )
                {
                    Console.WriteLine("Salimos a la noche");
                }
                else
                {
                    Console.WriteLine("No salimos :(");
                }
            }

            if ( principioDeMes & finDeSemana ) 
            {
                Console.WriteLine("salimos a la noche");
            }
            else
            {
                Console.WriteLine("No salimos :(");
            }

            // else if

            Console.WriteLine("Else if");

            if (false)
            {
                // esto se cumple?
            }
            else if (false)
            {
                // etc
            }

            


            Console.ReadKey();

        }
    }
}
