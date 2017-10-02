using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColumbSwitch 
{
    class Prefijo 
    {
        
        /// <summary>
        /// Muestra al usuario las opciones para los prefijos
        /// </summary>
        public void mostrarC()
        {
            Console.WriteLine("Escoja las unidades");
            Console.WriteLine("1) [C]");
            Console.WriteLine("2) [mC]");
            Console.WriteLine("3) [uC]");
            Console.WriteLine("4) [nC]");

        }

        /// <summary>
        /// Muestra al usuario las opciones para los prefijos
        /// </summary>
        public void mostrarM()
        {
            Console.WriteLine("Escoja las unidades");
            Console.WriteLine("1) [m]");
            Console.WriteLine("2) [cm]");
            Console.WriteLine("3) [mm]");


        }

        
        /// <summary>
        /// El usuario escoge el prefijo, la funcion devuelve el valor calculado
        /// </summary>
        /// <param name="seleccion"></param>
        /// <param name="valor">Valor a convertir</param>
        /// <returns></returns>
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
                    Console.WriteLine("Introduce una opcion listada");
                    return prefijosC(validaDato(), valor);
                    
            }

            return valor;
        }

        /// <summary>
        /// Convierte en unidades de longitud a SI
        /// </summary>
        /// <param name="seleccion"></param>
        /// <param name="valor"></param>
        /// <returns></returns>
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
                    Console.WriteLine("Introduce una opcion listada");
                    return prefijosM(validaDato(), valor);
                    
            }

            return valor;
        }
        /// <summary>
        /// Evita que el usuario ingrese opciones no deseados
        /// </summary>
        /// <returns></returns
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
