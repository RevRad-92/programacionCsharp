using System;

namespace Operadores_Aritmeticos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double var1 = 100;
            double var2 = 10;
            double varResultado = 0;
            bool varResultadoBooleano = false;


            #region Operadores Aritmeticos
            Console.WriteLine("Operadores Aritmeticos");


            Console.WriteLine();

            Console.WriteLine($"Var1 ={var1}");
            Console.WriteLine("Var2 = {0}",var2);
            Console.WriteLine();

            varResultado = var1 + var2;


            Console.WriteLine($"Var1 + Var2 = {varResultado}");


            varResultado = var1 - var2;


            Console.WriteLine($"Var1 - Var2 = {varResultado}");


            varResultado = var1 * var2;


            Console.WriteLine($"Var1 x Var2 = {varResultado}");


            varResultado = var1 / var2;


            Console.WriteLine($"Var1 / Var2 = {varResultado}");



            Console.WriteLine("Modulo");
            var1 = 102;
            Console.WriteLine($"Var1 ={var1}");

            varResultado = var1 % var2; // Modulo , es el resto de la división


            Console.WriteLine($"Var1 Modulo Var2 = {varResultado}");

            Console.WriteLine("Potencia");
           
            varResultado = Math.Pow(var2,2); // Argumentos  : Base y Exponente

            Console.WriteLine($"Var2 a la potencia 2   ={varResultado}");


            Console.WriteLine("Raiz Cuadrada");
            var1 = 100;
            Console.WriteLine($"Var1 ={var1}");

            varResultado = Math.Sqrt(var1); // Argumentos  : Base y Exponente

            Console.WriteLine($"Raiz cuadrada de Var1   ={varResultado}");



            #endregion
           
            
            Console.ReadKey();

            Console.Clear();

            Console.Beep();


            #region incrementales / modificadores de la asignación


            Console.WriteLine("Incrementales");

            var1 = var1 + 1;
            Console.WriteLine($"Var1 +1 ={var1}");

            var1++; // Incrementa en  1 , tambien puede decrementa --> var1--;


            Console.WriteLine($"var++={var1}");

            var1 = 1;

            var1 = var1 + 15;

            Console.WriteLine($"Var1 + 15 ={var1}");

            var1 += 15;

            /*Igual que var1 +15 , mas eficiente y se puede utilizar
             * Con otras operaciones ejemplo var1 *=5 , var1 -= 4 , var1 /=1; */

            varResultado = 0;

            varResultado = ++var1; // Se incrementa var1 y luego asigno el valor final al resultado

            Console.WriteLine(varResultado); // Deberia valer var1 +1

            varResultado = 0;

            varResultado = var1++; // Asigno el valor de var1 y luego la incremento

            Console.WriteLine(varResultado); // Deberia valer var1
            Console.WriteLine(var1); // Deberia valer var1+1



            #endregion

            Console.ReadKey();

            Console.Clear();

            Console.Beep();

            #region Operadores de relación 
            Console.WriteLine("Operadores de Relación / Comparación");

            var1 = 10;
            var2 = 20;


            Console.WriteLine($"Var1 ={var1}");
            Console.WriteLine("Var2 = {0}", var2);
            Console.WriteLine();

            varResultadoBooleano= var1 > var2; // Var1 es mayor que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 > var2 : {varResultadoBooleano}");


            varResultadoBooleano = var1 < var2; // Var1 es menor que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 < var2 : {varResultadoBooleano}");

            varResultadoBooleano = var1 == var2; // Var1 tiene el mismo valor que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 == var2 : {varResultadoBooleano}");

            // == IGUAL  Y != Distinto podemos usarlos para otro tipo de datos

            varResultadoBooleano = var1 != var2; // Var1 es distinto que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 != var2 : {varResultadoBooleano}");


            varResultadoBooleano = var1 > var2; // Var es mayor que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 >= var2 : {varResultadoBooleano}");

            varResultadoBooleano = var1 <= var2; // Var es menor igual que var 2 ? --> True /false

            Console.WriteLine($"Resultado var1 <= var2 : {varResultadoBooleano}");


            #endregion













            Console.ReadKey();

        }
    }
}
