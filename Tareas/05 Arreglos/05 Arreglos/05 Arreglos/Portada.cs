using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Arreglos
{
    class Portada
    {
        /// <summary>
        /// Creates the main label of the program
        /// </summary>
        /// <param name="titulo">Insert the program title</param>
        public Portada(String titulo)
        {
            Console.Title = titulo;
            //Establece el color de fondo a blanco - requiere del comando clear
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // Asegura que toda la ventana sea de color blanco
            //Establece el color de la letra
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\t\t\t Tecnicas de Programación");
            Console.WriteLine("\t\t\t  Sandoval Penilla Oscar");
            Console.WriteLine("\t\t\t    " + titulo);
            Console.WriteLine("\t\t\t\t Grupo 3 ");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\n\n\n\n");
            enunciado();
            Console.WriteLine("\t\t Pulsa una cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n");

            
        }

        //Muestra el enunciado del Problema 
        public void enunciado()
        {
            Console.WriteLine("Este programa puede calcular Media / Varianza / Curtosis / Desviacion Estandar de un grupo de personas.");
            Console.WriteLine("*** Notas: 1) Se utilizan arreglos para los cálculo                  ***");
            Console.WriteLine("***        2) Las formulas empleadas son para Muestras Poblacionales ***");
            Console.WriteLine("\n\n\n\n\n\n");
            
        }
    }
}
