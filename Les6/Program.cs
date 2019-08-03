using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a1 =  { { 1, 2,3,5},
                           { 3, 4,3,5 } };
            Matrix A = new Matrix(a1);
            int[,] b1 = { { 1, 2},
                         { 3, 4},
                         { 3, 4}};
            Matrix B = new Matrix(b1);
            int[,] c1 =  { { 1, 2,3,5},
                           { 3, 4,3,5 } };
            Matrix C = new Matrix(c1);
            try
            {
                Matrix CCC = A + C;
                CCC.OutputArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
