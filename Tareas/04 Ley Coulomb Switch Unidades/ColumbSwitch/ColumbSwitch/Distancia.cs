using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbSwitch
{
    class Distancia
    {
        Prefijo Q1 = new Prefijo();
        public double Dist(string x, string y, string r)
        {
            //El usuario introduce la separacion entre las cargas q1 y q2
            Console.Write("Introducta la separacion entre las cargas " + x + " y " + y + " \n" + r + " = ");
            double dist = Q1.validaDato();
            Q1.mostrarM();
            dist = Q1.prefijosM(Q1.validaDato(),dist);
            do //Evita que la distancia de separacion entre cargas sea cero
            {
                
                if (dist == 0)
                {
                    Console.WriteLine("Divición entre cero, intente nuevamente.");
                    Console.Write("Introduzca el valor de la distancia " + r + " =");

                    dist = Q1.validaDato();

                }

            } while (dist == 0);
            Console.WriteLine(r + " = " + dist + "[m]");
            Console.WriteLine("\n\n\n\n\n\n\n");

            return dist;
        }
    }
}
