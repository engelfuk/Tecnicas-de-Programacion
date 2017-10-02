using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Tecnicas_de_Programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ley de Coloumb";
            //Establece el color de fondo a blanco - requiere del comando clear
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // Asegura que toda la ventana sea de color blanco
            //Establece el color de la letra
            Console.ForegroundColor = ConsoleColor.Black;


            Console.WriteLine("\t\t\t Tecnicas de Programación");
            Console.WriteLine("\t\t\t  Sandoval Penilla Oscar");
            Console.WriteLine("\t\t\t\t Grupo 3 \n\n");
            
            Console.WriteLine("Calcular la fuerza resultante [N] entre tres cargas puntales  en el eje X a una cierta distancia d [cm].");
            Console.Write("Porfavor introducta el valor de la carga q1 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("en [uC]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("q1= ");
            double q1 = double.Parse(Console.ReadLine());
            Console.Write("Porfavor introducta el valor de la carga q2 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("en [uC]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("q2= ");
            double q2 = double.Parse(Console.ReadLine());
            Console.Write("Porfavor introducta el valor de la carga q3 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("en [uC]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("q3= ");
            double q3 = double.Parse(Console.ReadLine());
            Console.Write("Introducta el valor de la distancia r_12 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("en [cm]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("r_12= ");
            double r_12;
            do
            {
                r_12 = double.Parse(Console.ReadLine());
                if (r_12 == 0)
                {
                    Console.WriteLine("Divición entre cero, intente nuevamente.");
                    Console.Write("Introducta el valor de la distancia r_12 ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("en [cm]");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("r_12= ");
                }

            } while (r_12 == 0);

            Console.Write("Introducta el valor de la distancia r_23 ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("en [cm]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("r_23= ");
            double r_23;
            do
            {
                r_23 = double.Parse(Console.ReadLine());
                if (r_23 == 0)
                {
                    Console.WriteLine("Divición entre cero, intente nuevamente.");
                    Console.Write("Introducta el valor de la distancia r_23 ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("en [cm]");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write("r_23= ");
                }

            } while (r_23 == 0);

            double K = 9e9;

            //Operaciones matematicas
            q1 = q1 * 10e-6;
            q2 = q2 * 10e-6;
            q3 = q3 * 10e-6;
            double Qt_12 = Math.Abs(q1 * q2);
            double Qt_23 = Math.Abs(q2 * q3);
            r_12 = r_12 * 10e-2;
            r_23 = r_23 * 10e-2;
            r_12 = Math.Pow(r_12, 2);
            r_23 = Math.Pow(r_23, 2);
            double F1 = (K * Qt_12) / r_12;
            double F2 = (K * Qt_23) / r_23;
            

            if (q1 * q2 > 0)
            {
                F1 = F1 * (1);
            }
            else
            {
                F1 = F1 * (-1);
            }
            if (q2 * q3 > 0)
            {
                F2 = F2 * (-1);
            }
            else
            {
                F2 = F2 * (1);
            }

            double F = F1 + F2;
            Console.WriteLine("                     " + q1 + " * " + q2);
            Console.WriteLine("F12 = " + K + "* --------------------- = " + F1 + " [N]");
            Console.WriteLine("                         " + r_12);
            Console.WriteLine("                     " + q2 + " * " + q3);
            Console.WriteLine("F23 = " + K + "* --------------------- = " + F2 + " [N]");
            Console.WriteLine("                         " + r_23);
            //Muestra en pantalla el resultado
            Console.Write("La fuerza es F = ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(F + " en [N] \n\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------Gracias-----------------------------");







            //Evita que la ventana se cierre
            Console.ReadKey();
        }
    }
}
