using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            int num1 = 0, num2 = 0;

            Console.WriteLine("Operadores Lógicos");

            Console.WriteLine($"var1 = {var1}");
            Console.WriteLine($"var2 = {var2}");

            Console.WriteLine("Operador AND (\"&\"");
            Console.WriteLine($"var1 & var2 = {var1 & var2}"); // and lógico. Devuelve bool depende se cumpla la condicion
            // Evalúa ambas variables
            Console.WriteLine($"var1 && var2 = {var1 && var2}"); // short circuit: evalúa sólo la primera si no necesita la segunda. Ej: var1 = false, toda la expresión será falsa.

            Console.WriteLine("Operador OR");
            Console.WriteLine($"var1 | var2 = {var1 |var2}");  // or lógico. 
            Console.WriteLine($"var1 || var2 = {var1 ||var2}"); // or short circuit

            Console.WriteLine("NOR");

            Console.WriteLine($"Verdadero NOR Verdadero: {!(var1 | var1)}");


            Console.WriteLine("NAND");

            Console.WriteLine($"Verdadero NAND Verdadero: {!(var1 & var1)}");


            Console.WriteLine("XOR");

            Console.WriteLine($"Verdadero XOR Verdadero: {var1 ^ var1}");

            // ver tabla de la verdad


            Console.WriteLine("No siempre da lo mismo usar && en vez de &");

            num1 = 0;
            num2 = 0;

            if ((num1 != 0) & (num2 < (num2=num2 + 1)))
            {
                // something
            }

            Console.WriteLine("num2: " + num2); // num2 = 1

            Console.WriteLine("Con short circuit:");

            num1 = 0;
            num2 = 0;

            if ((num1 != 0) && (num2 < (num2 = num2 + 1)))
            {
                // something
            }

            Console.WriteLine("num2: " + num2); // num2 = 0


            Console.ReadKey();

        }
    }
}
