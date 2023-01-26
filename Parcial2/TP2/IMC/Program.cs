using System;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1)
            double[,] matriz = {
                            {94, 1.74, 0, 0 },
                            { 78, 1.76, 0, 0 },
                            { 74, 1.72, 0, 0},
                            { 62, 1.61, 0, 0}
            };

            string[] estados = { "Bajo", "Normal", "Sobrepeso", "Obesidad" }; // 5)
            string[] campos = { "Peso", "Est. ", "IMC", "Estado" };

                                  
            // 4) bucle for: completar IMC y ESTADO
            for (int i = 0; i < matriz.GetLength(0); i++)
            {

                matriz[i, 2] = CalcularIMC(matriz[i,0], matriz[i,1]);
                matriz[i, 3] = SetearEstado(matriz[i, 2]);

            }


            // 6) mostrar tabla completa

            for (int i = 0; i < campos.Length; i++)
            {
                Console.Write($"{campos[i]}|");
            }
            Console.WriteLine();


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // persona
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    // atributo

                    if( j == 3)
                    {
                        Console.Write($"{estados[Convert.ToInt32(matriz[i, j]) - 1]} |");
                    } else
                    {
                        Console.Write($"{matriz[i, j]} |");

                    }
                }
                Console.WriteLine();
            }


            Console.ReadKey();

        }

        // 2)
        static double CalcularIMC(double peso, double estatura)
        {

            return Math.Round(peso / Math.Pow(estatura, 2), 2);
        }

        // 3)
        static int SetearEstado(double imc)
        {
            if (imc < 18.5)
            {
                return 1;
            }
            else if (imc >= 18.5 && imc <= 24.99)
            {
                return 2;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                return 3;
            }
            else if (imc >= 30)
            {
                return 4;
            }
            else
            {
                return 0;
            }


        }

       
    }
}
