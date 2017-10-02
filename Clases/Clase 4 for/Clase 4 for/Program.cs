using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aproximacion PI";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\t\t\t Tecnicas de programación");
            Console.WriteLine("\t\t\t\t Grupo 2  ");
            Console.WriteLine("\t\t\t  Sandoval Penilla Oscar\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Este programa realiza una aproximación del valor de PI, haciendo uso de la suma de Leibnitz.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Presione Control + C para interrumpir");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Ingresa el número de ciclos deseados para calcular la aproximación\n");
            Console.Write("No. Ciclos = ");

            double fin = double.Parse(Console.ReadLine());

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

            
            for (int i = inicio; i <= fin; i++, n=n+2)
            {
                suma_anterior = suma;
                signo = Math.Pow(-1,i+1);  //genera el cambio de signo de la potencia  
                expresion = expresion + i;
                suma = 4 * (1 / n) * signo;
                suma = suma + suma_anterior;
                
                Console.WriteLine("No. Ciclo {0} \t Aprox {1}",i,suma);
                


            }

            











            ////Primer Ciclo for
            //for (int i = 10; i >= 5; i--)
            //{
            //    Console.WriteLine("i = {0}", i);
            //}


            ////Segundo Ciclo For
            //for (double d = 1.01D; d < 1.10; d += 0.01D)
            //{
            //    Console.WriteLine("d = {0}", d);
            //    //}


            //    //Tercer ciclo for
            //    double i=0;
            //for (;;)
            //{
                
            //    Console.WriteLine("i = {0}", i);
            //    if (i==10)
            //    {
            //        break; 
            //    }
            //    i++;
            //}

            Console.ReadKey();
        }
    }
}
