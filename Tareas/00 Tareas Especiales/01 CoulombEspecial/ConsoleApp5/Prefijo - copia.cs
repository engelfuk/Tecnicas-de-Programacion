using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoulombEspecial
{
    class Prefijo
    {
        
        //Muestra al usuario las opciones para los prefijos
        public void mostrarC()
        {
            Console.WriteLine("Escoja las unidades");
            Console.WriteLine("1) [C]");
            Console.WriteLine("2) [mC]");
            Console.WriteLine("3) [uC]");
            Console.WriteLine("4) [nC]");

        }
        public void mostrarM()
        {
            Console.WriteLine("Escoja las unidades");
            Console.WriteLine("1) [m]");
            Console.WriteLine("2) [cm]");
            Console.WriteLine("3) [mm]");
            

        }

        //El usuario escoge el prefijo, la funcion devuelve el valor calculado
        public double prefijosC(double seleccion, double valor)
        {
            

            switch (seleccion)
            {
                case 1: //[C]
                    valor = valor * 1e0;
                    break;
                case 2: //[mC]
                    valor = valor * 1e-3;
                    break;
                case 3: //[uC]
                    valor = valor * 1e-6;
                    break;
                case 4: //[nC]
                    valor = valor * 1e-9;
                    break;

                default:
                    Console.WriteLine("Opcion incorrecta se tomara la carga en [uC]");
                    valor = valor * 1e-6;
                    break;
            }

            return valor;
        }

        public double prefijosM(double seleccion, double valor)
        {


            switch (seleccion)
            {
                case 1: //[m]
                    valor = valor * 1e0;
                    break;
                case 2: //[cm]
                    valor = valor * 1e-2;
                    break;
                case 3: //[mm]
                    valor = valor * 1e-3;
                    break;
                
                default:
                    Console.WriteLine("Opcion incorrecta se tomara la distancia en [m]");
                    valor = valor * 1e0;
                    break;
            }

            return valor;
        }

        //Evita que el usuario ingrese opciones no deseados
        public double validaDato()
        {

            double x;
            bool isDouble = Double.TryParse(Console.ReadLine(), out x);
            while (!isDouble)
            {
                Console.WriteLine("Introduce una opcion valida");

                isDouble = Double.TryParse(Console.ReadLine(), out x);
            }
            return x;
        }

        
    }
}
