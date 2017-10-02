using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Metodos
    {
        /// <summary>
        /// Prevents the user make invalid input
        /// </summary>
        /// <param name="instruccion">Shows the User a text</param>
        /// <param name="texto2">Shows the input variable</param>
        /// <returns></returns>
        public double validaDato(string instruccion, string texto2)
        {
            Console.WriteLine(instruccion);
            Console.Write(texto2 + " = ");
            double x;
            bool isDouble = Double.TryParse(Console.ReadLine(), out x);
            while (!isDouble)
            {
                Console.WriteLine("Introduce una opcion valida");

                isDouble = Double.TryParse(Console.ReadLine(), out x);
            }
            return x;

            
        }
        /// <summary>
        /// Prevents the user make invalid input
        /// </summary>
        /// <returns></returns>
        public double validaDato()
        {
            double x;
            bool isDouble = Double.TryParse(Console.ReadLine(), out x);
            while (!isDouble || x<=0)
            {
                Console.WriteLine("Introduce una opcion valida");

                isDouble = Double.TryParse(Console.ReadLine(), out x);
            }
            return x;


        }
        /// <summary>
        /// Prevents the user make invalid input
        /// </summary>
        /// <param name="instruccion">Shows the User a text</param>
        /// <returns></returns>
        public double validaDato(string texto)
        {
            Console.Write(texto);
            double x;
            bool isDouble = Double.TryParse(Console.ReadLine(), out x);
            while (!isDouble)
            {
                Console.WriteLine("Introduce una opcion valida");

                isDouble = Double.TryParse(Console.ReadLine(), out x);
            }
            
            return x;

            
        }
        /// <summary>
        /// Print in console the user options
        /// </summary>
        /// <param name="texto">Output Console text</param>
        public void Mostrar(string texto)
        {
            Console.WriteLine(texto);
            Console.WriteLine("1) Media");
            Console.WriteLine("2) Varianza");
            Console.WriteLine("3) Desviacion Estandar");
            Console.WriteLine("4) Curtosis");
            Console.WriteLine("5) Todas las anteriores");
        }
        /// <summary>
        /// Calculte the Variance of a sample 
        /// </summary>
        /// <param name="arreglo"></param>
        /// <returns></returns>
        public double Varianza(double[] arreglo)
        {
            double resultado = 0;

            foreach (var item in arreglo)
            {
                resultado += Math.Pow((item - arreglo.Average()), 2);
            }

            return resultado / (arreglo.Length-1);
        }
        /// <summary>
        /// Calculte the Standard Deviation
        /// </summary>
        /// <param name="arreglo">Double array</param>
        /// <returns></returns>
        public double DesStandar(double[] arreglo)
        {
            return Math.Sqrt(Varianza(arreglo));
        }

        public double Curtosis(double[] arreglo)
        {
            double resultado = 0, n = 0;
            n = arreglo.Length;

            //Calcula el cuarto momento
            for (int i = 0; i < arreglo.Length; i++)
            {
                resultado += Math.Pow((arreglo[i] - arreglo.Average()) / DesStandar(arreglo), 4);
            }
            return resultado = resultado * (n * (n + 1)) / ((n - 1) * (n - 2) * (n - 3)) - 3 * (Math.Pow((n - 1), 2)) / ((n - 2) * (n - 3));
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="seleccion">User input parameter</param>
        /// <param name="arreglo">double array</param>
        /// <returns></returns>
        public void Operaciones(double seleccion, double[] arreglo)
        {
            
            double[] aux = new double[arreglo.Length];

            switch (seleccion)
            {
                case 1: //Media
                    Console.WriteLine("Promedio = " + arreglo.Average() + " [m]");
                    break;

                case 2: //Varianza
                    Console.WriteLine("Varianza = " + Varianza(arreglo)+ " [m^2]");
                    break;

                case 3: //Desviacion Estandar
                    Console.WriteLine("Desviación Standar = " + DesStandar(arreglo) + " [m]");
                    break;


                case 4: //Curtosis
                    Console.WriteLine("Curtosis = " + Curtosis(arreglo));
                    break;

                case 5:
                    Console.WriteLine("Promedio = "+ arreglo.Average() + " [m]") ;
                    Console.WriteLine("Varianza = " + Varianza(arreglo) + " [m^2]");
                    Console.WriteLine("Desviación Standar = " + DesStandar(arreglo) + " [m]");
                    Console.WriteLine("Curtosis = "  + Curtosis(arreglo));

                    break;
                    

                default:
                    //Evita que se ingrese una opcion no deseada
                    Mostrar("Opcion Invalida Escoge Nuevamente ");
                    Operaciones(validaDato(), arreglo);
                    break;
            }

            
        }

        
    }
}
