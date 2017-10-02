using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Transformaciones
{
    class OperadoresMatriciales
    {
        #region Variables Globales
        private double[,] mat1 = new double[2,2];
        private double[,] mat2;
        private double[,] vect1 = new double[2,1];

        #endregion
        public double[,] MultMatMat(double[,] mat1, double[,] mat2)
        {
            this.mat1 = mat1;
            this.mat2 = mat2;
            double aux = 0;
            double[,] mat = new double[mat1.GetLongLength(0), mat1.GetLongLength(1)];
            for (int j = 0; j < mat1.GetLongLength(0); j++)
            {
                for (int k = 0; k < mat1.GetLongLength(1); k++)
                {
                    aux = 0;
                    for (int n = 0; n < mat1.GetLongLength(1); n++)
                    {
                        aux += mat1[k, n] * mat2[n, j];
                    }

                    //mat[k,j] = mat1[k,0] * mat2[0,j] + mat1[k,1] * mat2[1,j] + +mat1[k, 2] * mat2[2, j];
                    mat[k, j] = aux;
                }
                
            }
            return mat;
        }

        
        public double[] MutMatVect(double[] mat, double[] vect)
        {
            return null;
        }
    }
}
