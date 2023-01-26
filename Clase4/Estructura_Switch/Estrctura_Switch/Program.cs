using System;

namespace Estrctura_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int estacion = 5;
            int var = 2;
            //bool varBool = true;
            //string nombre = "Juan";

            Console.WriteLine("Switch");

            Console.WriteLine("Estamos en la estación: ");

            switch (estacion) // dentro del paréntesis no va una expresión booleana, sino un dato a evaluar.
            {
                case 1:
                    Console.WriteLine("Verano");
                    break;
                case 2:
                    Console.WriteLine("Otoño");
                    break;
                case 3:
                    Console.WriteLine("Invierno");
                    break;
                case 4:
                    Console.WriteLine("Primavera");
                    break;

                default: // "else"
                    Console.WriteLine("Error");
                    break;
            }
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Switch por rangos");

            switch (var)
            {
                case 0:
                    Console.WriteLine("Var es igual a 0");
                    break;
                case 2:
                    
                case 1:

                case 3:
                    if (var == 2)
	                {
                        Console.WriteLine("Var es igual a 2");
	                }

                    Console.WriteLine("Var vale 1, 2 o 3");
                    break;

                case 4:

                    goto case 6; // ir al caso con valor 6

                case 5:
                    Console.WriteLine("Var vale 5");
                    break;
                    
                case 6:
                    Console.WriteLine("Vale 4 o 5");

                    break;

                default:
                    Console.WriteLine("No está contemplado el valor de var");
                    break;
            }

            Console.ReadKey();
        }
    }
}
