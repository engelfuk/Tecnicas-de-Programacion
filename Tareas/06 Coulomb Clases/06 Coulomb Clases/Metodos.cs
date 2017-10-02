using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _06_Coulomb_Clases
{
    class Metodos 
    {
        /// <summary>
        /// Devuelve la Norma de un vector
        /// </summary>
        /// <param name="arreglo"></param>
        /// <returns></returns>
        public double Norma(double[] arreglo)
        {
            double norma = 0;
            for (int i = 0; i < arreglo.Length; i++)
            {
                norma += Math.Pow(arreglo[i],2);
            }

            return Math.Sqrt(norma);
        }

        /// <summary>
        /// Duelve el vector unitario de un vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public double[] Unitario(double[] vector)
        {
            double norma = Norma(vector);
            
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = vector[i] / norma;
            }

            return vector;
        }

        /// <summary>
        /// Devuele el angulo en un vector
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public double Angulo(double[] vector)
        {
            double angulo = Math.Atan2(vector[1],vector[0]);
            angulo = angulo * 180 / Math.PI;

            return angulo;
        }










    }
}
