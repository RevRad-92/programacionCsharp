using System;

namespace Break_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 1;
            bool flag = true;

            Console.WriteLine("Break");

            while (flag)
            {

                if (numero < 10)
                {
                    
                    Console.WriteLine($"Numero: {numero}");
                }
                else
                {
                    flag = false;
                }

                if (numero % 2 == 0)
                {
                    break; // termina el while que lo contiene.
                }

                numero++;

            }

            Console.WriteLine("Salí antes del bucle por el break");



            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Continue");

            flag = true;
            numero = 1;

            while (flag)
            {
                if (numero <= 20)
                {
                    if (numero == 4)
                    {
                        numero++; // siempre incrementar antes de un continue (para evitar bucle infinito)
                        continue; // vuelve a evaluar el while
                        // no va a imprimir el número 4.
                    }

                    Console.WriteLine($"Numero: {numero}");

                }
                else
                {

                    flag = false;
                }

                numero++;


            }


            Console.ReadKey();
        }
    }
}
