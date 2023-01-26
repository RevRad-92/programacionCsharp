using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** para utilizar notas con decimales y redondear como se suele hacer--> promedio - (int)promedio == 0 ---> restar la parte entera para ver si da cero. Si es distinto de cero, es double.

            /*
             if (promedio - (int) promedio != 0)
            {
                matriz[2,i] = 1+ (int)promedio;
            }
            else
            {
                matriz[2,i] = (int)promedio;
            }

             
             */

            int[,] alumnos = new int[20, 4];
            Random random = new Random();
            int total = 0;
            int promedio = 0;
            string[] estado = { "Reprobado", "Promocion", "Final" };

            Console.WriteLine("Ejercicio 2");


            // Genero notas
            for (int i = 0; i < alumnos.GetLength(0); i++)
            {
                for (int j = 0; j < alumnos.GetLength(1) ; j++)
                {

                    if (j < 2)
                    {
                        alumnos[i, j] = random.Next(1, 11);
                        total += alumnos[i, j];
                        promedio = total / 2;
                        alumnos[i, 2] = promedio;

                        // funcion para estado
                        alumnos[i, 3] = SetEstado(promedio);
                        Console.Write($"{alumnos[i, j]} | ");

                    } else if (j == 3)
                    {
                        Console.Write($"{estado[alumnos[i, j] - 1]} | ");
                    }
                    else
                    {
                        Console.Write($"{alumnos[i, j]} | "); 
                    }


                }
                Console.WriteLine();
                
                total = 0;
                
            }



            // mostrar tabla entera 
            //for (int i = 0; i < alumnos.GetLength(0); i++)
            //{
            //    for (int j = 0; j < alumnos.GetLength(1); j++)
            //    {
            //        if (j == 3)
            //        {
            //            Console.Write($"{estado[alumnos[i,j]-1]} | ");
            //        } else
            //        {

            //            Console.Write($"{alumnos[i, j]} | ");
            //        }
                    


            //    }

            //    Console.WriteLine();
            //}

            


            Console.ReadKey();


        }

        static int SetEstado(int promedio)
        {
            

            if (promedio < 4)
            {
                return 1;
            } else if (promedio >= 7)
            {
                return 2;
            }
            else
            {
                return 3;
            }


            
        }

        
    }
}
