using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputUsuario = "";
            bool continuar = true;
            int x = 0;

            Console.WriteLine("While");

            while (continuar) 
            {
                Console.WriteLine("Hola, ingresá algo que quieras imprimir en pantalla");
                Console.Write(": ");
               
                inputUsuario = Console.ReadLine();

                Console.WriteLine($"Ingresaste: {inputUsuario}");

                Console.WriteLine("Querés continuar? S/N");
                Console.Write(": ");

                if (Console.ReadLine().ToUpper() == "S")
                {
                    continuar = true;
                    Console.Clear();

                } else
                {
                    Console.WriteLine("Estoy fuera del while");
                    continuar = false;
                }


                //Console.WriteLine("Hola");
                //x++;

                //if (x == 5)
                //{
                //    continuar = false;
                //}
            }
            
            Console.WriteLine("Muchas gracias");

            Console.ReadKey();
        }
    }
}
