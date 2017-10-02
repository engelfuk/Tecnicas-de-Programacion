using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancian los objetos para utlizar los metodos
            Metodos met = new Metodos();

            //Se impprime la portada del programa
            Portada portada = new Portada("Tarea 05 Arreglos");
            double datX = 0;

            

            //Asegura que se cree un arreglo , no acepta numeros negativos ni ceros
            do
            {
                datX = met.validaDato("Selecciona la cantidad de datos que desees ingresar", "Datos");
                
            } while (datX <= 0);
            double[] datos = new double[Convert.ToInt32(datX)]; //Se crea un arreglo de la longitud deseada por el usuario

            Console.WriteLine("\nIngrese los datos en metros [m]");

            //El usuario introduce los valores dentro el arreglo
            for (int i = 0; i < datos.Length; i++)
            {
                Console.Write("Dato No." + (i + 1) + " = ");
                datos[i] = met.validaDato();
                
            }
                
                       
            met.Mostrar("\n\nEscoge el calculo deseado");
            met.Operaciones(met.validaDato("Opcion: "),datos);
            //Console.WriteLine("Resultado = " + resultado);
            Console.ReadKey();
        }
    }
}
