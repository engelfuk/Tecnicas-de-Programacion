using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase Switch";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("\t\t\t Tecnicas de Programación");
            Console.WriteLine("\t\t\t  Sandoval Penilla Oscar");
            Console.WriteLine("\t\t\t\t Grupo 3 \n\n");

            int valor = 0;
            switch (valor)
            {
                case 0:
                case 1:
                    Console.WriteLine("Estoy en caso 0 o 1");
                    break;

                case 5:
                    Console.WriteLine("Estoy en el caso carga");
                    break;

                case 7:
                    Console.WriteLine("Estoy en el caso asdf");
                    break;

                default:
                    Console.WriteLine("Este es el caso por defecto");
                    break;
            }

            Console.ReadKey();
        }
    }
}
