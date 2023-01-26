using System;

namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables (todas arriba)
            double var1 = 100;
            double var2 = 10;
            double varResultado = 0;
            bool varResultadoBool = false;

            #region operadores aritméticos
            Console.WriteLine("Operadores Aritméticos");
            
            Console.WriteLine();
            
            Console.WriteLine($"var1 = {var1}");

            Console.WriteLine();

            varResultado = var1 + var2;

            Console.WriteLine($"var1 + var2 = {varResultado}");

            varResultado = var1 - var2;

            Console.WriteLine($"var1 - var2 = {varResultado}");

            varResultado = var1 * var2;

            Console.WriteLine($"var1 * var2 = {varResultado}");

            varResultado = var1 / var2;

            Console.WriteLine($"var1 / var2 = {varResultado}");


            Console.WriteLine("Módulo");
            var1 = 102;
            Console.WriteLine($"var1 = {var1}");
            varResultado = var1 % var2; // modulo: resto de la división

            Console.WriteLine($"var1 Módulo var2 = {varResultado}");

            Console.WriteLine("Potencia");
            var1 = 10;
            Console.WriteLine($"var1 = {var1}");
            varResultado = Math.Pow(var2,2); // Argmts (base, exponente)

            Console.WriteLine($"var2 ^ 2 = {varResultado}");

            Console.WriteLine("Raíz");
            var1 = 100;
            Console.WriteLine($"var1 = {var1}");
            varResultado = Math.Sqrt(var1); 

            Console.WriteLine($"Raíz cuadrada de Var1 = {varResultado}");

            #endregion

            #region incrementales

            
            Console.ReadKey();

            Console.Clear();
            Console.Beep();

            Console.WriteLine("Incrementales");

            var1 = var1 + 1;
            Console.WriteLine($"Var1 + 1 = {var1}");

            var1++; // más eficiente (trabaja a nivel de bit), decrementar -> var1 --;

            Console.WriteLine($"Var1 ++ = {var1}");

            var1 = 1;

            var1 = var1 + 15;
            Console.WriteLine($"Var1 + 15 = {var1}");


            var1 += 15; // también -=, *=, /=
            Console.WriteLine($"Var1 += 15: {var1}");



            varResultado = 0;

            varResultado = ++var1; // se incrementa var1 y luego asigno el valor final a la variable.
            Console.WriteLine(varResultado); // var1 + 1

            varResultado = 0;
            varResultado = var1++; // asigno var1 y luego la incremento.
            Console.WriteLine(varResultado); // debería valer var1 ( = 0 )
            Console.WriteLine(var1); // debería valer var1 + 1

            #endregion

            Console.ReadKey();

            Console.Clear();
            Console.Beep();

            #region operadores de relacion / comparacion

            Console.WriteLine("Operadores de Relación/Comparación");

            var1 = 10;
            var2 = 20;

            Console.WriteLine($"Var1 = {var1}");
            Console.WriteLine($"Var2 = {var2}");
            Console.WriteLine();

            // *** usar variable bool, porque double no puede almacenar true o false
            varResultadoBool = var1 > var2;
            Console.WriteLine($"var1 > var2 : {varResultadoBool}");

            varResultadoBool = var1 < var2;
            Console.WriteLine($"var1 < var2 : {varResultadoBool}");

            varResultadoBool = var1 == var2; // comparación, no igualación
            Console.WriteLine($"var1 == var2 : {varResultadoBool}");
            

            varResultadoBool = var1 != var2;
            Console.WriteLine($"var1 != var2 : {varResultadoBool}");

            varResultadoBool = var1 <= var2;
            Console.WriteLine($"var1 <= var2 : {varResultadoBool}");

            varResultadoBool = var1 >= var2;
            Console.WriteLine($"var1 >= var2 : {varResultadoBool}");

            #endregion

            

            Console.ReadKey();
            Console.Clear();
        }
    }
}
