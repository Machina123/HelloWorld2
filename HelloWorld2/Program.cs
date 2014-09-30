using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Miejsce na kod
        }
    }

    class Matrix
    {

        public static double[,] CreateMatrix(int m, int n)
        {
            double[,] C = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Wprowadź element [{0},{1}]: ", i, j);
                    C[i, j] = int.Parse(Console.ReadLine());
                }
            }

                return C;
        }

        public static double[,] AddMatrix(double[,] A, double[,] B, int m, int n)
        {
            double[,] C = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            return C;
        }

        public static void PrintMatrix(double[,] M, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }

        public static double[,] MultipyMatrixByNumber(double[,] A, double k, int m, int n)
        {
            double[,] C = new double[m, n];

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    C[i, j] = A[i, j] * k;
                }
            }

            return C;
        }

        public static double[,] MultiplyMatrix(double[,] A, double[,] B, int m, int n, int k)
        {
            double[,] C = new double[m, k];
            return C;
        }
    }
}