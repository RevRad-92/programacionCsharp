using System;

namespace Estructura_IF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 10;
            int var2 = 10;
            bool principioDeMes = true;
            bool finDeSemana = false;

            Console.WriteLine("Condicionales");

            //if simple

            Console.WriteLine("if");

            bool resultado = var1 == var2;
            if ( (var1 == var2) & (var1 == 10))
            {
                // Se ejecuta si la condición da un true
                Console.WriteLine("El valor de ambas variables es el mismo y var1 es igual a 10");

            }

            //if else

            Console.WriteLine("if - else");
            if (var1 != var2)
            {
                // Se ejecuta si la condición da un true
                Console.WriteLine("El valor de ambas variables es distinto");

            }
            else
            {

                Console.WriteLine("Ambas variables son iguales");
            }


            //if anidado

            Console.WriteLine("If anidado");

            if (principioDeMes == true)
            {
                if (finDeSemana)
                {

                    Console.WriteLine("Salimos a la noche");

                }
                else
                {
                    Console.WriteLine("No salimos :( ");

                }


            }

            // Otra manera de sortear el if anidado es concatenar condiciones
            if (principioDeMes & finDeSemana)
            {
                Console.WriteLine("Salimos a la noche");


            }
            else
            {

                Console.WriteLine("No salimos :( ");

            }


            //else if

            if (false)
            {
                // esto se cumple?
            }else if (false)
            {
                //y esto se cumple?

            }
            else if (false)
            {
                //y esto ?

            }
            else if (false)
            {
                // y asi sigo....

            }


         














            Console.ReadKey();


        





        }
    }
}
