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
            double[,] mat1 = { {1,2,3 }, {4,5,6 }, {7,8,9 } };
            double[] vect = { 1,2,3};

            Matrices m1 = new Matrices(mat1);

            double[,] res = m1.MultMatMat(mat1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(res[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
