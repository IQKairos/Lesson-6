using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6
{
    class Matrix
    {        
            int[,] matrica1;
            public Matrix(int[,] a )
            {
            matrica1 = a;
            }           
        public static Matrix operator +(Matrix A, Matrix B)
        {
            int row = A.matrica1.GetUpperBound(0) + 1;
            int col = A.matrica1.GetUpperBound(1) + 1;
            int[,] C = new int[row, col];            
            for (int i = 0; i <= row-1; i++)
            {
                for (int j = 0; j<= col-1; j++)
                {
                   C[i, j] = A.matrica1[i, j] + B.matrica1[i, j];
                }
            }
            Matrix res = new Matrix(C);
            return res;
        }
        public static Matrix operator -(Matrix A, Matrix B)
        {
            int row = A.matrica1.GetUpperBound(0) + 1;
            int col = A.matrica1.GetUpperBound(1) + 1;
            int[,] C = new int[row, col];

            for (int i = 0; i <= row - 1; i++)
            {
                for (int j = 0; j <= col - 1; j++)
                {
                    C[i, j] = A.matrica1[i, j] - B.matrica1[i, j];
                }
            }
            Matrix res = new Matrix(C);
            return res;
        }
        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (A.matrica1.GetLength(1) != B.matrica1.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] C = new int[A.matrica1.GetLength(0), B.matrica1.GetLength(1)];

            for (int i = 0; i < A.matrica1.GetLength(0) ; i++)
            {
                for (int j = 0; j < B.matrica1.GetLength(1); j++)
                {
                    for (int k = 0; k < B.matrica1.GetLength(0); k++)
                    {
                        C[i, j] += A.matrica1[i, k] * B.matrica1[k, j];
                    }
                }
            }
            Matrix res = new Matrix(C);
            return res;
        }
        public void OutputArray() 
        {
            int i, j;

            for (i = 0; i < matrica1.GetUpperBound(0) + 1; i++)
            {
                for (j = 0; j < matrica1.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("{0}\t", matrica1[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
