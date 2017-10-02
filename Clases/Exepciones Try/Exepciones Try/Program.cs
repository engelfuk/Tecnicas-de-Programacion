using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caratula;

namespace Exepciones_Try
{
    class Program
    {
        static void Main(string[] args)
        {
            Portada portada = new Portada("   Manejo de Exepciones");

            try
            {
                double a, b;
                Console.WriteLine("Ingresa el valor de a");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa el valor de b");
                b = Convert.ToDouble(Console.ReadLine());
                double[] c = { 5, 5, 5, 5, 5 };
                

                Console.WriteLine("El valor de c = {0}", c[0]);
            }
            //catch (Exception error)
            //{

            //    Console.WriteLine(error.Message);
            //}
            catch (IndexOutOfRangeException error)
            {
                Console.WriteLine(error.Message);
            }
            catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                //Siempre se ejecuta 
                Console.WriteLine("Estoy en el finally");
            }
            

            Console.ReadLine();
        }
    }
}
