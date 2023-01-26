using System;

namespace Notas
{
    public enum Estado
    {
        Reprobado=1,
        Promocion,
        Final


    }


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Dada una Matriz diseñada para 20 alumnos inscriptos en una materia
              Completar los resultados del primer y segundo parcial
              Calcular en una columna el promedio de notas de cada alumno
              Calcular en una columna el estado del alumno al final del cuatrimestre de 1 a 3, 1 para reprobado, 2 para
               promoción ,3 para dar el final.
              Calcular el estado con una función.
              Condiciones para : Reprobado (Promedio < 4) , Promoción (promedio >= 7) , Final ( promedio >= 4 y promedio< 7)

             */

            int x = 4, y = 20;
            int[,] matriz = new int[x, y];
            Random rand = new Random();
            double promedio = 0;

            // Completar la matriz con los parciales


            // En este caso me poso en el primer parcial y completo todas las notas y luego hago lo mismo con el 2do.

         for (int i = 0; i < matriz.GetLength(0)-2; i++)
            {

                for (int j = 0; j < matriz.GetLength(1); j++)
                {

                    matriz[i, j] = rand.Next(1, 11);



                }

            }
            /*
                // Aca completo por cada aluno sus dos parciales
           for (int i = 0; i < matriz.GetLength(1); i++)
                {

                    for (int j = 0; j < matriz.GetLength(0)-2; j++)
                    {

                        matriz[j, i] = rand.Next(1, 11);



                    }

                }
          */



            //     Calculo el promedio y el estado

            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                promedio = Convert.ToDouble(matriz[0, i] + matriz[1, i]) / 2;// Para tratar los decimales

                if (promedio - (int)promedio!=0 )
                {
                    matriz[2, i] = 1 + (int)promedio;


                }
                else
                {
                    matriz[2, i] = (int)promedio;
                }


                matriz[3, i] = CalcularEstado(matriz[2, i]);



            }













            // Imprimo la tabla 

            for (int i = 0; i < matriz.GetLength(1); i++)
            {

                Console.WriteLine($"Alumno {i + 1}:");


                for (int j = 0; j < matriz.GetLength(0); j++)
                {

                    if (j!=3)
                    {
                        Console.Write($"|{matriz[j, i]}");

                    }else
                    {
                        Console.Write($"|{(Estado)matriz[j, i]}");
                    }
                  

                }

                Console.WriteLine();

            }

            Console.ReadKey();

            















        }



        static int CalcularEstado(int promedio)
        {

            if (promedio < 4)
            {
                return 1;

            }
            if (promedio >= 7)
            {
                return 2;

            }

            if (promedio < 7 & promedio >3)
            {
                return 3;

            }

            return -1;


        }












    }
}
