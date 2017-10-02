using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caratula;
using ColumbSwitch;


namespace _06_Coulomb_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crea la portada del Programa con informacion del mismo
            Portada portada = new Portada(" Coulomb Clases o Objetos");
            



            //Se crean las cargas en el plano
            Cargas q1 = new Cargas("1");
            Cargas q2 = new Cargas("2");

            
            //Cargas q1 = new Cargas(3e-6,3e-2,2e-2,0);
            //Cargas q2 = new Cargas(1e-6, -3e-2, 0e-2, 0);

            //Verifica si las cargas se encuentran en la misma ubicacion
            if ((q1.darPosicion[0] == q2.darPosicion[0]) && (q1.darPosicion[1] == q2.darPosicion[1]) )
            {
                Console.WriteLine("\n\nERROR");
                Console.WriteLine("------------------------------------------------------\n");
                Console.WriteLine("Las Cargas se encuentran en el mismo punto.");

            }
            else//Imprime los Resultados en caso de no estar en el mismo punto
            {
                Console.WriteLine("\n\nRESULTADOS");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("F12 = " + q1.FuerzaXY(q1, q2)[0] + "[i] \t" + q1.FuerzaXY(q1, q2)[1] + "[j]" + "\t[N]");
                Console.WriteLine("|F12| = " + q1.darMagFuerza(q1, q2) + "[N]\t" + " Angulo = " + q1.Angulo(q1.FuerzaXY(q1, q2)) + "°");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("F21 = " + q2.FuerzaXY(q2, q1)[0] + "[i] \t" + q2.FuerzaXY(q2, q1)[1] + "[j]" + "\t[N]");
                Console.WriteLine("|F21| = " + q2.darMagFuerza(q2, q1) + "[N]\t" + " Angulo = " + q2.Angulo(q2.FuerzaXY(q2, q1)) + "°");
                Console.WriteLine("------------------------------------------------------------\n");
                Console.WriteLine("Distancia = " + q2.Norma(q2.VecPos(q1,q2)) + "[m]");
                Console.WriteLine("------------------------------------------------------------\n");

            }
            
            Console.ReadKey();
            
            
        }


    }
}
