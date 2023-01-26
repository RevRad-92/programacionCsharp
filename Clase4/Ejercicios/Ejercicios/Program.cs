using System;


namespace Ejercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            //Console.WriteLine("ejercicio 1");

            //int nro1 = 1, nro2 = 500, nro3 = 250;

            //if ( nro1 > nro2 && nro1 > nro3 )
            //{
            //    Console.WriteLine("nro1 es es el mayor");
            //} else if ( nro2 > nro1 && nro2 > nro3 )
            //{
            //    Console.WriteLine("nro2 es el mayor");
            //} else if ( nro3 > nro1 && nro3 > nro2 )
            //{
            //    Console.WriteLine("nro3 es el mayor");
            //} else
            //{
            //    Console.WriteLine("No existe un número mayor a otro");
            //} 
            #endregion

            #region Ejercicio 2
            //Console.WriteLine("Ejercicio 2");

            //int a = 10, b = -2, c = 5;

            //if ( a > 0 && b > 0 )
            //{
            //    Console.WriteLine($"a * b = {a * b}");
            //} else if ( a > 0 && c > 0 )
            //{
            //    Console.WriteLine($"a * c = {a * c}"); 
            //} else if ( b > 0 && c > 0)
            //{
            //    Console.WriteLine($"b * c = {b * c}");
            //} else
            //{
            //    Console.WriteLine("No hay dos números positivos para multiplicar entre si");
            //} 
            // USAR VARIABLE RESULTADO PARA MOSTRARLO
            #endregion

            Console.WriteLine("Ejercicio 3 - Switch");

            int nroIngresado1 = 0, nroIngresado2 = 0, resultado = 0;
            string operacion = "";
            bool flag = false;

            Console.Write("Ingrese un número: ");
            
            nroIngresado1 = Convert.ToInt32(Console.ReadLine());

             
            Console.Write("Ingrese otro número: ");
            nroIngresado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la operación a realizar");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.Write("Opción elegida: ");
            
            operacion = Console.ReadLine();
                              
            switch (operacion)
            {
                case "1":

                    resultado = nroIngresado1 + nroIngresado2;
                    break;

                case "2":

                    resultado = nroIngresado1 - nroIngresado2;
                    break;

                case "3":

                    resultado = nroIngresado1 * nroIngresado2;
                    break;

                case "4":
                    if (nroIngresado2 == 0)
                    {
                        flag = true;
                        goto default;
                    }

                    resultado = nroIngresado1 / nroIngresado2;

                    break;

                default:

                    Console.WriteLine("No se puede realizar la operación");
                    break;
            }

            if (!flag)
            {
                Console.WriteLine($"El resultado es: {resultado}"); 
            }

            Console.ReadKey();
        }
    }
}
