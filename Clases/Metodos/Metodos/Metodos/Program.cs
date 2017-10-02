using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates the label of the program
            Portada portada = new Portada("Metodos");

            double[] arreglo1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double[] arreglo2 = {10,9,8,7,6,5,4,3,2,1 };

            double[] resultado = Suma(arreglo1,arreglo2);

            for (int i = 0; i <arreglo1.Length ; i++)
            {
                Console.Write(" "+ resultado[i
                    ]);
            }


            Console.ReadKey();
        }

        static void Hola()
        {
            Console.WriteLine("estoy en el metodo Hola");
        }


        static double[] Suma(double[] arreglo1, double[] arreglo2)
        {
            double[] resultado = new double[arreglo1.Length];

            for (int i = 0; i < arreglo1.Length; i++)
            {
                resultado[i] = arreglo1[i] + arreglo2[i];
            }

            return resultado;
        }
    }
}
