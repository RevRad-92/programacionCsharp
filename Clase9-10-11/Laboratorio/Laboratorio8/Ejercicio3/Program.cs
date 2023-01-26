using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 3");

            double[] inflacion = { 0.8, 0.1, 0.3, 0.4, 0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9 };
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
            //double inflacionAnual = 0; // total
            //double menor = inflacion[0];
            //double mayor = 0;
            //int menorMes = 0;
            //int mayorMes = 0;
            double total = 0;
            double minima = inflacion[0];
            double maxima = inflacion[0];
            int posicionMinima = 0;
            int posicionMaxima = 0;
            double promedio = 0;

            for (int i = 0; i < inflacion.Length; i++)
            {
                total += inflacion[i];
                promedio = total / inflacion.Length;

                if (inflacion[i] > maxima )
                {
                    maxima = inflacion[i];
                    posicionMaxima = i;
                }

                if (inflacion[i] < minima)
                {
                    minima = inflacion[i];
                    posicionMinima = i;
                }
                
               
            }

            Console.WriteLine($"La inflación anual fue de {total}%");
            Console.WriteLine($"La inflación promedio fue {promedio}%");
            Console.WriteLine($"La inflación mínima fue de {minima}% en {meses[posicionMinima]}");
            Console.WriteLine($"La inflación máxima fue de {maxima}% en {meses[posicionMaxima]}");



            
            //string mesNombre = "";
            //string mayorMesNombre = "";
            //string menorMesNombre = "";

            //for (int i = 0; i < inflacion.Length; i++)
            //{
            //    inflacionAnual += inflacion[i];

            //    switch (i)
            //    {
            //        case 0:
            //            mesNombre = "Enero";
            //            break;
            //        case 1:
            //            mesNombre = "Febrero";
            //            break;
            //        case 2:
            //            mesNombre = "Marzo";
            //            break;
            //        case 3:
            //            mesNombre = "Abril";
            //            break;
            //        case 4:
            //            mesNombre = "Mayo";
            //            break;
            //        case 5:
            //            mesNombre = "Junio";
            //            break;
            //        case 6:
            //            mesNombre = "Julio";
            //            break;
            //        case 7:
            //            mesNombre = "Agosto";
            //            break;
            //        case 8:
            //            mesNombre = "Septiembre";
            //            break;
            //        case 9:
            //            mesNombre = "Octubre";
            //            break;
            //        case 10:
            //            mesNombre = "Noviembre";
            //            break;
            //        case 11:
            //            mesNombre = "Diciembre";
            //            break;
            //        default:
            //            break;
            //    }



            //    if (inflacion[i] > mayor)
            //    {
            //        mayor = inflacion[i];
            //        mayorMes = i + 1;
            //        mayorMesNombre = mesNombre;
            //    }

            //    if (inflacion[i] < menor)
            //    {
            //        menor = inflacion[i];
            //        menorMes = i + 1;
            //        menorMesNombre = mesNombre;
            //    }
            //}

            



            //Console.WriteLine($"La inflación anual es {inflacionAnual}%");

            //Console.WriteLine($"La inflación más baja es la del mes {menorMes} - {menorMesNombre}: {menor}%");

            //Console.WriteLine($"La inflación más alta es la del mes {mayorMes} - {mayorMesNombre}: {mayor}%");

            //promedio = Convert.ToDouble(inflacionAnual) / Convert.ToDouble(inflacion.Length);

            //Console.WriteLine($"El promedio de inflación es {promedio}%");
        }
    }
}
