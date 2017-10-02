using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoulombEspecial
{
    class Program
    {

        static void Main(string[] args)
        {
            Prefijo Q1 = new Prefijo(); //Se instancia un nuevo objeto para poder utilizar sus metodos
            do
            {
                //Imprime nombre de la materia, nombre y grupo
                Portada portada = new Portada("Tarea Extra Coulomb");
                portada.enunciado();

                //El usuario introduce el valor de la carga q1
                Console.Write("Porfavor introducta el valor de la carga q1 \nq1 = ");
                
                double q1 = Q1.validaDato(); // Evita que el usuario ingrese opciones invalidas
                Q1.mostrarC(); // Muestra al usuario los prefijos disponibles
                q1 = Q1.prefijosC(Q1.validaDato(), q1); //La carga toma el valor en las unidades SI
                Console.WriteLine("q1 = " + q1 + "[C]");
                Console.WriteLine("\n\n\n\n\n\n\n");

                //El usuario introduce el valor de la carga q2
                Console.Write("Porfavor introducta el valor de la carga q2 \nq2 = ");
                double q2 = Q1.validaDato();
                Q1.mostrarC();
                q2 = Q1.prefijosC(Q1.validaDato(), q2);
                Console.WriteLine("q2 = " + q2 + "[C]");
                Console.WriteLine("\n\n\n\n\n\n\n");

                //El usuario introduce el valor de la carga q3
                Console.Write("Porfavor introducta el valor de la carga q3 \nq3 = ");
                double q3 = Q1.validaDato();
                Q1.mostrarC();
                q3 = Q1.prefijosC(Q1.validaDato(), q3);
                Console.WriteLine("q3 = " + q3 + "[C]");
                Console.WriteLine("\n\n\n\n\n\n\n");

                //El usuario introduce la separacion entre las cargas q1 y q3
                Console.Write("Introducta la separacion entre las cargas q1 y q3 \nr13 = ");
                double r_13;
                do //Evita que la distancia de separacion entre cargas sea cero
                {
                    r_13 = Q1.validaDato();
                    if (r_13 == 0)
                    {
                        Console.WriteLine("Divición entre cero, intente nuevamente.");
                        Console.Write("Introduzca el valor de la distancia r_13 =");

                    }

                } while (r_13 == 0);
                Q1.mostrarM();
                r_13 = Q1.prefijosM(Q1.validaDato(), r_13);
                Console.WriteLine("r_13 = " + r_13 + "[m]");
                Console.WriteLine("\n\n\n\n\n\n\n");


                //Distancia entre la carga q1 y q2
                double r_12;
                

               

                //Verifica que el signo de las cargas permita calcular una que la carga quede entro del rango dado
                if ((q1 > 0 && q2 > 0 && q3 > 0) || (q1 > 0 && q2 < 0 && q3 > 0) || (q1 < 0 && q2 > 0 && q3 < 0) || (q1 < 0 && q2 < 0 && q3 < 0))
                {
                    r_12 = (-r_13 * (Math.Sqrt(q1 * q3) - q1)) / (q1 - q3);
                    
                    
                    //Resuelve el caso las cargas de los extremos tienen el mismo valor
                    if (q1 == q2)
                    {
                        r_12 = r_13 / 2;
                    }

                    //Imprime en pantalla los resultados finales
                    Console.WriteLine("R12 = {0}[m]   R23 = {1}[m]  R13={2}[m]", r_12, r_13 - r_12, r_13);
                    Console.WriteLine("q1 = {0}[C]  q2= {1}[C]  q3 = {2}[C] \n\n", q1, q2, q3);


                    Calculos nuevo = new Calculos();
                    nuevo.imprimirCargas(r_13 - r_12, r_13);
                }
                else
                {
                    Console.WriteLine("No es posible calcular una distancia talque la fuerza sea cero.");
                    Console.WriteLine("Revisa el signo de las Cargas");
                }

                Console.WriteLine("\n\nPresiona 1 para volver a correr el programa nuevamente");
                Console.WriteLine("Ingrese cualquier otro numero para salir");

            } while ( Q1.validaDato() == 1 );

            

            
        }

        
    }
}
