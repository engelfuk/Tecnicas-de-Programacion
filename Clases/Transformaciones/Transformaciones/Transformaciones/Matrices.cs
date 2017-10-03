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

        public double[,] MultMatMat(double[,] matriz)
        {
            double[,] aux = new double[this.matriz.GetLength(1), matriz.GetLength(0)];

            for (int i = 0; i < this.matriz.GetLength(1); i++)
            {
                for (int j = 0; j < matriz.GetLength(0); j++)
                {
                    aux[i, j] = this.matriz[i, 0] * matriz[0,j] + this.matriz[i, 1] * matriz[1, j] + this.matriz[i, 2] * matriz[2, j];
                }
            }

            return aux;
        }

    }
}
