using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoulombEspecial
{
    class Calculos
    {
        //Imprime en pantalla una aproximacion de la separacion de las cargas
        public void imprimirCargas(double valor1, double valor2)
        {
            double x = valor1 / valor2;
            if (x >= 0 && x<= 0.25) //Si la carga se encuentra a menos de 1/4 de la distancia
            {
                Console.WriteLine("\t\t **     **                  **");
                Console.WriteLine("\t\t*q1* - *q2* ---- ---- ---- *q3*");
                Console.WriteLine("\t\t **     **                  **");
            }
            else
            {
                if ( x> 0.25 && x <= 0.5) //Si la carga se encuentra entre un 1/4 y 1/2 de la distancia
                {
                    Console.WriteLine("\t\t **             **             **");
                    Console.WriteLine("\t\t*q1* ---- ---- *q2* ---- ---- *q3*");
                    Console.WriteLine("\t\t **             **             **");
                }
                else
                {
                    if (x > 0.5 && x <= 0.75) //Si la carga se encuentra entre un 1/2 y 3/4 de la distancia
                    {
                        Console.WriteLine("\t\t **                  **        **");
                        Console.WriteLine("\t\t*q1* ---- ---- ---- *q2* ---- *q3*");
                        Console.WriteLine("\t\t **                  **        **");
                    }
                    else //Si la carga se encuentra entre a mas de 3/4 de la distancia
                    {
                        Console.WriteLine("\t\t **                       **     **");
                        Console.WriteLine("\t\t*q1* ----- ---- ---- --- *q2* - *q3*");
                        Console.WriteLine("\t\t **                       **     **");
                    }
                }
            }
        }
    }
}
