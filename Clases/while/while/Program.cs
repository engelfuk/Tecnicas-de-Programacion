using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ciclo While";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t\t Tecnicas de Programacion");
            Console.WriteLine("\t\t\t\t Grupo 2");
            Console.WriteLine("\t\t\t Sandoval Penilla Oscar");

            Console.WriteLine("Este programa realiza una aproximación del valor de PI, haciendo uso de la suma de Leibnitz.");
            Console.WriteLine("Ingresa el porcentaje de error (0-100)%\n");
            Console.Write("% = ");

            //int i = 0;

            //while (i<20)
            //{
            //    if (i>5)
            //    {
            //        Console.WriteLine("Estoy dentro de if");
            //    }
            //    if (i<5)    
            //    {
            //        Console.WriteLine("Estoy dentro de otro if");
            //    }

            //    Console.WriteLine("Ciclo no. {0}",i);
            //    i++;
            //}

            try
            {

                double porcen = double.Parse(Console.ReadLine());
                porcen = (100 - porcen) / 100;

                //paso 1 definir el problema
                //paso 2 definir entradas y salidas
                //paso 3 herramientas
                //paso 4 tener una solucion verdadera (solucion a mano)
                //paso 5 teclear el codigo

                // que debe ir en la memoria math, consola, background, foreground, if, for, que es visual estudio, variable, while


                int inicio = 1;
                double expresion = 0;
                double suma = 0;
                double suma_anterior = 0;
                double signo = 1;
                double n = 1;


                //for (int i = inicio; i <= fin; i++, n = n + 2)
                //{
                //    suma_anterior = suma;
                //    signo = Math.Pow(-1, i + 1);  //genera el cambio de signo de la potencia  
                //    expresion = expresion + i;
                //    suma = 4 * (1 / n) * signo;
                //    suma = suma + suma_anterior;

                //    Console.WriteLine("No. Ciclo {0} \t Aprox {1}", i, suma);



                //}

                int i = 0;

                while ((suma <= Math.PI - Math.PI * porcen) || (suma >= Math.PI + Math.PI * porcen))
                {
                    suma_anterior = suma;
                    signo = Math.Pow(-1, i);  //genera el cambio de signo de la potencia  
                    expresion = expresion + i;
                    suma = 4 * (1 / n) * signo;
                    suma = suma + suma_anterior;

                    Console.WriteLine("No. Ciclo {0} \t Aprox {1}", i, suma);
                    i++;
                    n = n+2;
                }

                Console.WriteLine(Math.PI);
                Console.WriteLine(Math.PI + Math.PI*0.09);
                Console.WriteLine(Math.PI - Math.PI * 0.09);
            }
            catch (Exception error)
            {

                Console.WriteLine("Error " + error.Message);
            }


            Console.ReadKey();


        }
    }
}
