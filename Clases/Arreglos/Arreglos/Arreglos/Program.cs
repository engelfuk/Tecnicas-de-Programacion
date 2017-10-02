using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        //Temas vistos en clase:
        //length
        // arreglos tipos int, string

        static void Main(string[] args)
        {
            Portada portada = new Portada("Arrglos");

            //double[] arreglo = { 0,1,2,3,4,5};
            //Console.WriteLine("Longitud arreglo " + arreglo.Length);

            //for (int i = 0; i < arreglo.Length; i++)
            //{
            //    Console.WriteLine(arreglo[i]);
            //}

            //string[] var = new string[10]; // Crea un arreglo del un tamano variable

            //for (int i = 0; i < var.Length; i++)
            //{
            //    var[i] = i.ToString();
            //}

            //for (int i = 0; i < var.Length; i++)
            //{
            //    Console.WriteLine("hola " + var[i]);
            //}
            double valorInicial = 0 , valorFinal = 3, incremento = 0.1;
            double longitudArreglo = Math.Round((valorFinal - valorInicial)/incremento+1);
            double[] arregloVar = new double[Convert.ToInt32(longitudArreglo)];

            for (int i = 0; i < arregloVar.Length; i++, valorInicial++)
            {
                arregloVar[i] = valorInicial;
            }

            for (int i = 0; i < arregloVar.Length; i++)
            {
                Console.WriteLine(arregloVar[i]);
            }

            Console.WriteLine("La longitud del arreglo es: " + arregloVar.Length);

            //Tarea para martes 5
            //Media, Variancia, Desviacion estandar, curtosis

            //Console.WriteLine(arreglo[0]);

            Console.ReadKey();

        }
    }
}
