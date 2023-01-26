using System;

namespace TipoDatos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración de Variable

            bool varBoolean;

            #region Enteros
            int varInt; // número entero de 32 bits (Int32)
            
            uint varUint; // unsigned (UInt32)
            long varLong; // número entero 
            #endregion

            double varDouble;
            decimal varDecimal;

            string varString; // caracteres
            DateTime varDateTime; 
            

            // Asignación Valores en variable

            varBoolean = false;
            varInt = 1423654534;
            varString = @"Esta es una cadena de caracteres \ / $# 23 !! "; // @ indica que debe ser todo literal, incluso la contrabarra para escapar ("\")
            varDateTime = DateTime.Now; // según región y formato
                                        // .Date .Day .DayOfWeek, etc
                                       

            varDouble = 12.556222; //
            varDecimal = 12.556222m; // Guardar double en decimal (sufijo m, para no escribir todos los decimales de número tipo Decimal)

            
            // Declaración y asignación

            SByte varByte = 127; // número de 8 bits (número 127 con signo)

            SByte varByte1 = 122, varByte2 = 104;

            int? var1nullable = 0; // declarar con tipo? para que soporte null. No todos los tipos de datos soportan null.
            int? var2nullable = null;


            Console.WriteLine("El valor de varBoolean es: " 
                + varBoolean 
                + " continúo...");
            Console.WriteLine("El valor de varDecimal es: {1} y varDouble es: {0}", varDouble, varDecimal); // en las {} (placeholder) se pone una posición, correspondiente a las variables que le pasamos luego.
            Console.WriteLine($"El valor de varInt es: {varInt}"); // $ indica que va a haber expresiones o variables. 


            // + - * /

            varInt = 2 + 5; // 7 
            varInt = varInt + 1; // 8

            // Asignación compacta
            varInt += 1; // sumar 1 a lo que tenga la variable
            varInt++; // suma 1
            varInt--; // resta 1
           

            Console.ReadKey();
        }
    }
}
