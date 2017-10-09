using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
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
            Console.WriteLine("\t\t\t" + titulo);
            Console.WriteLine("\t\t\t\t Grupo 3 ");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\n\n\n\n");
            enunciado();
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t Pulsa una cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n");

            
        }

        public Portada()
        {
            //Console.Title = titulo;
            //Establece el color de fondo a blanco - requiere del comando clear
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear(); // Asegura que toda la ventana sea de color blanco
            //Establece el color de la letra
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\t\t\t Tecnicas de Programación");
            Console.WriteLine("\t\t\t  Sandoval Penilla Oscar");
            //Console.WriteLine("\t\t\t" + titulo);
            Console.WriteLine("\t\t\t\t Grupo 3 ");
            Console.WriteLine("\t\t =========================================");
            Console.WriteLine("\n\n\n\n");
            enunciado();
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t Pulsa una cualquier tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("\n\n\n\n\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n");


        }


        /// <summary>
        /// Muestra el enunciado del Problema 
        /// </summary>
        public void enunciado()
        {
            Console.WriteLine("Este programa calcula las Fuerzas que experimentan dos Cargas en el plano. \nAsi como la distancia entre ellas.");
            Console.WriteLine("\n\t*** Nota: Se expresan las  fuerza en termino de los vectores I,J,K ***");
            Console.WriteLine("\t*** asi como su magnitud y ángulo.                                 ***");
            
        }
    }
}
