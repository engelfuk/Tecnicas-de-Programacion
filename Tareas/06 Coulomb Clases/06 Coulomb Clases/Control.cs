using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Coulomb_Clases
{
    class Control
    {
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

        /// <summary>
        /// Evita que el usuario ingrese opciones no deseados Muestra al usario lo que ingreso
        /// </summary>
        /// <returns></returns
        public double validaDato(string texto)
        {
            Console.Write("Introduce el valor de " + texto);
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
