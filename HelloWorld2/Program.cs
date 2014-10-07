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
            Matrix m = new Matrix();

            int a=3, b=4;

            Console.WriteLine("Macierz A -->");
            double[,] A = m.CreateMatrix(a,b);
            Console.WriteLine(Environment.NewLine + "Macierz B -->");
            double[,] B = m.CreateMatrix(a, b);

            Console.WriteLine(Environment.NewLine + "Macierz A -->");
            m.PrintMatrix(A, a, b);

            Console.WriteLine(Environment.NewLine + "Macierz B -->");
            m.PrintMatrix(B, a, b);

            Console.WriteLine(Environment.NewLine + "Dodawanie macierzy");
            m.PrintMatrix(m.AddMatrix(A, B, a, b), a, b);

            Console.Read();
        }
    }

    class Matrix
    {

        public double[,] CreateMatrix(int m, int n)
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

        public double[,] AddMatrix(double[,] A, double[,] B, int m, int n)
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

        public void PrintMatrix(double[,] M, int m, int n)
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

        public double[,] MultipyMatrixByNumber(double[,] A, double k, int m, int n)
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

        public double[,] MultiplyMatrix(double[,] A, double[,] B, int m, int n, int k)
        {
            double[,] C = new double[m, k];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    C[i, j] = 0;
                    for (int r = 0; r < n; r++)
                        C[i, j] += A[i, r] * B[r, j];
                }
            }
            return C;
        }
    }
}