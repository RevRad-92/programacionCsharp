using System;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true;
            bool var2 = false;
            int num1= 0,num2=0;


            Console.WriteLine("Operadores Logicos");


            Console.WriteLine($"Var1 = {var1}");
            Console.WriteLine($"Var2 = {var2}");

            Console.WriteLine("Operador AND \"&\"");

            Console.WriteLine($"var1 & var2 = {var1 & var2}"); // and logico
            Console.WriteLine($"var1 && var2 = {var1 && var2}"); // and short circuit


            Console.WriteLine("Operador OR");

            Console.WriteLine($"var1 | var2 = {var1 | var2}"); // or logico
            Console.WriteLine($"var1 || var2 = {var1 || var2}"); // or short circuit

            Console.WriteLine("No siempre da lo mismo usar && en vez de &");

            num1 = 0;
            num2 = 0;

            if ((num1 !=0) & (num2 < (num2=num2+1)))
            {
                //hace algo

            }

            Console.WriteLine("Num2:" + num2);

            Console.ReadKey();


            num1 = 0;
            num2 = 0;

            if ((num1 != 0) && (num2 < (num2 = num2 + 1)))
            {
                //hace algo

            }

            Console.WriteLine("Num2:" + num2);

            Console.ReadKey();








        }
    }
}
