using System;

namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 4");

            int antiguedad = 0, opcion = 0;
            string categoria = "";
            bool horas = false;
            double basicoDE = 100, basicoC = 200, basicoAB = 400;
            double salario = 0, plus = 20;

            Console.Write("Seleccione la categoría: \n1.A o B\n2.C\n3.D o E\n");
            Console.Write("Categoría: ");
            categoria = Console.ReadLine().ToLower();

            Console.Write("Indique los años de antiguedad: ");
            antiguedad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Trabajó más de 8 horas diarias?: \n1.Si\n2.No\n");
            Console.Write("Respuesta: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            
            if (opcion == 1)
            {
                horas = true;

            }
            else
            {
                horas = false;
            }


            switch (categoria)
            {
                case "a": 
                    // al estar vacío, si entra en "a" pasa al próximo.
                case "b": 
                    salario = basicoAB;
                    break;
                case "c": 
                    salario = basicoC;
                    break;
                case "d": 
                    // pasa al siguiente
                case "e":
                    salario = basicoDE;
                    break;
                default:
                    Console.WriteLine("La categoría no existe");
                    break;
            }

            if (antiguedad >= 5 && horas == true)
            {
                salario += plus;

            } else if (antiguedad < 5)
            {
                salario -= salario * 0.9;
            }

            Console.WriteLine($"El salario es ${salario}");
            Console.ReadKey();
        }
    }
}
