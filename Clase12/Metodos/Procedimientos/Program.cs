using System;
using System.Net.Mail;

namespace Procedimientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Nicolás";
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Procedimientos");

            Console.WriteLine("Procedimientos con parámetros");
            DarBienvenida(); // llamado a metodo (procedimiento)
            Presentar(nombre); // Pide si o si argumento

            Saludar(nombre);
            Saludar(11);
            Saludar();
            Calcular(2, 2);

            Console.WriteLine("Procedimientos con parámetros opcionales");

            // ParametrosOpcionales(1); // Error
            ParametrosOpcionales(1, 2);
            ParametrosOpcionales(1, 2, 3);
            ParametrosOpcionales(1, 2, param4: 4); // saltea parametro de posición 3.
            ParametrosOpcionales(1, 2, 3, 4);

            Console.WriteLine("Procedimientos con parámetros por referencia");

            Sumar(num1, ref num2); // muestra valores incrementados
            // por referencia, cambia la variable inicial que se pasa como parámetro. Sirve para afectar la variable inicial.
            
            
            Console.WriteLine($"El valor de num1 fuera del procedimiento es: {num1}");
            Console.WriteLine($"El valor de num2 fuera del procedimiento es: {num2}");



            Console.ReadKey();
        
        }

        // Declaración de estructura del procedimiento
        // void: palabra reservada (no devuelve nada)
        static void DarBienvenida()
        {
            // alcance de variables etc es solo dentro de las llaves del procedimiento.

            Console.WriteLine("Hola a todos, estoy escribiendo desde el procedimiento");  
            
        }

        static void Presentar(string nombreCompleto) 
        {
            Console.WriteLine($"Mi nombre es {nombreCompleto}");
        }


        // Mismo procedimiento (nombre), diferentes firmas (parámetros)
        static void Saludar(string nombre)
        {

            Console.WriteLine($"Hola a todos, mi nombre es {nombre}");
            
        }

        static void Saludar(int nombre)
        {

            Console.WriteLine($"Hola a todos, mi nombre es {nombre}");

        }

        static void Saludar()
        {

            Console.WriteLine($"Hola a todos!!");

        }

        static void Calcular(int num1, int num2)
        {
            Console.WriteLine("Realizamos una cuenta");
            Console.WriteLine($"2+2 = {num1 + num2}");
        }

        static void ParametrosOpcionales(int param1, int param2, int param3 = 0, int param4 = 10) // Parámetros opcionales van siempre al final. Se le asigna un valor por defecto.
        {

            Console.WriteLine($"Parametro 1 = {param1} - Parametro 1 = {param1} - Parametro 2 = {param2} - Parametro 3 = {param3} - Parametro 4 = {param4} -");


        }

        static void Sumar(int num1, ref int num2)
        {
            num1 = num1 + 1;
            num2 = num2 + 1;

            Console.WriteLine($"El valor de num1 dentro del procedimiento es: {num1}");
            Console.WriteLine($"El valor de num2 dentro del procedimiento es: {num2}");

        }


    }
}
