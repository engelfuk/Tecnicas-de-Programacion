using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transformaciones
{
    class Matrices
    {
        private double[,] matriz;

        public Matrices(double[,] matriz)
        {
            this.matriz = matriz;
        }

        /// <summary>
        /// Multiplica una matriz 4x4 por un vector 4x1
        /// </summary>
        /// <param name="vect">dimension 4x1</param>
        /// <returns></returns>
        public double[] MultMatVect(double[] vect)
        {
            double[] res = new double[vect.Length];
            for (int i = 0; i < matriz.GetLength(1); i++)
            {
                for (int j = 0; j < vect.Length; j++)
                {
                    res[i] += matriz[i,j]*vect[j] ;
                }
                
            }

            return res;
        }

        /// <summary>
        /// Multiplica dos matrices 4x4
        /// </summary>
        /// <param name="matriz">matriz 4x4</param>
        /// <returns></returns>
        public double[,] MultMatMat(double[,] matriz)
        {
            double[,] aux = new double[this.matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < this.matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    aux[i, j] = this.matriz[i, 0] * matriz[0,j] + this.matriz[i, 1] * matriz[1, j] + this.matriz[i, 2] * matriz[2, j] + this.matriz[i, 3] * matriz[3, j];
                }
            }

            return aux;
        }

    }
}
