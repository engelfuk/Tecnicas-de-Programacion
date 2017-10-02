using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Portada
    {
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
            Console.WriteLine("\t\t\t\t Grupo 3 ");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t Pulsa una cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n");
        }

        //Muestra el enunciado del Problema 
        public void enunciado()
        {
            Console.WriteLine("Este programa calcula la Fuerza Neta sobre la carga q2.");
            Console.WriteLine("*** Nota: Las cargas se encuentran sobre el eje X ***");
            Console.WriteLine("\t\t\t Orden de las cargas");
            Console.WriteLine("\t\t\t *q1 \t*q2 \t*q3\n");
        }
    }
}
