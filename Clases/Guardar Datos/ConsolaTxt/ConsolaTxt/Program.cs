using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Consola_Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"C:\Users\engel\OneDrive - UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO\Semestre 7\dato.txt";
            //StreamWriter escritura = File.CreateText(ruta);
            //escritura.WriteLine("\t Tecnicas de programacion");
            //escritura.WriteLine("\t Grupo 3");
            //escritura.Close();

            //StreamWriter escritura;
            //escritura = File.AppendText(ruta);
            //escritura.WriteLine("Texto insertado");
            //escritura.Close();

            //Lectura de Datos
            StreamReader lectura = File.OpenText(ruta);
            string cadena;
            //cadena = lectura.ReadLine();
            //while (cadena != null) 
            //{
            //    Console.WriteLine(cadena);
            //    cadena = lectura.ReadLine();
            //}

            char[] separador = { '\t' };
            string[] campos;
            cadena = lectura.ReadLine();
            while (cadena!= null)
            {
                Console.WriteLine(cadena);
                campos = cadena.Split(separador);
                Console.WriteLine("th1 = {0} , th2 = {1} , th3 = {2}",campos[0], campos[1], campos[2]);
                cadena = lectura.ReadLine();
            }
            //campos = cadena.Split(separador);
            lectura.Close();
            string ruta2 = @"C:\Users\engel\OneDrive - UNIVERSIDAD NACIONAL AUTÓNOMA DE MÉXICO\datomove.txt";
            File.Move(ruta, ruta2);

            Console.ReadKey();


        }
    }
}
