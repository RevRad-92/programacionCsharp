using System;

namespace OperadorCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int var1 = 5;
            int varResultado = 0;
            string varStr = "";

            Console.WriteLine("Operador condicional o asignacion condicional");

            varResultado = (var1 > 3) ? 10 : 15;
            Console.WriteLine("varResultado = " + varResultado);


            varStr = (var1 > 3) ? "Var1 es mayor que 3" : "var1 no es mayor a 3";
            Console.WriteLine($"varStr = {varStr}");



            Console.ReadKey();
        }
    }
}
