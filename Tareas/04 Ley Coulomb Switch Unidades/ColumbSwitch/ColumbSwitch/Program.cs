using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea la portada del programa y muestra el enunciado del problema
            Portada portada = new Portada("Columb Switch");
            portada.enunciado();

            //Crea una instancia para ustilizar los metodos de la clase Prefijo
            Cargas q = new Cargas();
             

            double q1 = q.Carg("q1");
            double q2 = q.Carg("q2");
            double q3 = q.Carg("q3");

            //Crea una instancia para ustilizar los metodos de la clase Prefijo
            Distancia dist = new Distancia();

            double r_12 = dist.Dist("q1","q2","r12");
            double r_23 = dist.Dist("q2", "q3", "r23");

            //Operaciones Matematicas
            double K = 9e9;
            double Qt_12 = Math.Abs(q1 * q2);
            double Qt_23 = Math.Abs(q2 * q3);
            
            double F1 = (K * Qt_12) / (r_12* r_12);
            double F2 = (K * Qt_23) / (r_23* r_23);
            

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
            Console.WriteLine("F12 = " + K + "* --------------------- = " + F1 + "[i] [N]");
            Console.WriteLine("                         " + r_12);
            Console.WriteLine("                     " + q2 + " * " + q3);
            Console.WriteLine("F23 = " + K + "* --------------------- = " + F2 + "[i] [N]");
            Console.WriteLine("                         " + r_23);
            //Muestra en pantalla el resultado
            Console.WriteLine("Resultado :");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("F = " + F + "[i]    [N] \n\n");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--------------------------------Gracias-----------------------------");



            Console.ReadKey();
        }
    }
}
