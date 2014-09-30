#region Program
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
            int m, n1, n2, k;

            Console.Write("Podaj ilosc wierszy pierwszej macierzy: ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Podaj ilosc kolumn pierwszej macierzy: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Podaj ilosc wierszy drugiej macierzy: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Podaj ilosc kolumn drugiej macierzy: ");
            k = int.Parse(Console.ReadLine());

            if (n1 != n2)
            {
                Console.WriteLine("ErRoR! Macierzy nie można pomnożyć!");
            }
        }
    }

    class Matrix
    {
        private const int MAX_SIZE = 5;

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

        public static void PrintMatrix(double[,] M)
        {
            for (int i = 0; i < MAX_SIZE; i++)
            {
                for (int j = 0; j < MAX_SIZE; j++)
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

        /* SubtractMatrix
        public static double[,] SubtractMatrix(double[,] A, double[,] B)
        {
            double[,] C = new double[MAX_SIZE, MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                for (int j = 0; j < MAX_SIZE; j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }

            return C;
        }
        */

        /* DivideMatrixByNumber
        public static double[,] DivideMatrixByNumber(double[,] A, double k)
        {
            double[,] C = new double[MAX_SIZE, MAX_SIZE];

            for (int i = 0; i < MAX_SIZE; i++)
            {
                for (int j = 0; j < MAX_SIZE; j++)
                {
                    C[i, j] = A[i, j] / k;
                }
            }

            return C;
        }
        */

    }
}
#endregion Program