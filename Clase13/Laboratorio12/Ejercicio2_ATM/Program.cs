using System;
using System.Data;
using System.Diagnostics.SymbolStore;
using System.Runtime.InteropServices;

namespace Ejercicio2_ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 2 - ATM");

            int dni = 36686844;
            int pin = 1234;

            int indni;
            int inpin;

            bool sesion = false;
            string operacion = "";
            double saldo = 60000;

            Console.Write("Ingrese DNI: ");
            indni = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el PIN: ");
            inpin = Convert.ToInt32(Console.ReadLine());

            if (Login(indni, inpin, dni, pin))
            {
                sesion = true;
                Console.WriteLine("Bienvenido a ATM");
                Console.Beep();

                while (sesion)
                {
                    
                    Console.WriteLine("Seleccione la operación deseada: ");
                    Console.WriteLine("1. Informar saldo\n2. Depositar\n3. Extraer\n4. Salir");
                    operacion = Console.ReadLine();

                    Console.Clear();

                    switch (operacion)
                    {
                        case "1": // informar saldo
                            Saldo(ref saldo); 

                            break;
                        case "2": // depositar
                            
                            Depositar(ref saldo);
                            Saldo(ref saldo);

                            break;
                        case "3": // extraer
                            
                            Extraer(ref saldo);
                            Saldo(ref saldo);

                            break;
                        case "4": // salir
                            sesion = false;
                            break;
                        default:
                            Console.WriteLine("Operación inexistente.");
                            break;
                    }

                    


                }

                
                Console.WriteLine("Hasta la próxima!");
                Console.Beep();



            }
            else
            {
                Console.WriteLine("DNI o PIN incorrecto/s!");
                Console.Beep();
            }


            Console.ReadKey();
        }

        static bool Login(int indni, int inpin, int dni, int pin)
        {
            if (indni == dni && inpin == pin)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Saldo(ref double saldo) // por ref el nombre del parametro puede ser diferente a la variable pasada, pero apunta a la misma variable/espacio de memoria
        {
            Console.WriteLine($"Su saldo es ${Math.Round(saldo,2)}");
            
        }

        static void Depositar(ref double saldo)
        {
            
            Console.Write("Ingrese el monto: $");
            saldo += Convert.ToDouble(Console.ReadLine());

        }

        static void Extraer(ref double saldo)
        {
            double importe;
            
            Console.Write($"Ingrese el monto: $");
            importe = Convert.ToDouble(Console.ReadLine());

            if (saldo >= importe)
            {
                saldo -= importe;
                Console.WriteLine($"Retirando... ${importe}");
                
            }
            else
            {
                Console.WriteLine("Fondos insuficientes!");
                    
            }

            

        }







    }
}
