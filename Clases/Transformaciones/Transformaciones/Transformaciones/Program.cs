using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caratula;

namespace Transformaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Portada portada = new Portada("  Multiplicacion Matrices");
            double[,] mat1 = { { 0, 1, 2, 3 }, { 4, 5, 6, 7 }, { 8, 9, 10, 11 }, { 12, 13, 14, 15 } };
            double[,] mat2 = { { 0 }, { 1 }, { 2 }, { 3 } } ;

            OperadoresMatriciales m = new OperadoresMatriciales();
            double[,] mat = m.MultMatMat(mat1,mat2);

            for (int j = 0; j < mat.GetLongLength(0); j++)
            {
                for (int k = 0; k < mat.GetLongLength(1); k++)
                {
                    Console.Write(mat[j,k] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
