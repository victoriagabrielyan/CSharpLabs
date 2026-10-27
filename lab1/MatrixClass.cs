using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    internal class MatrixClass
    {
        private int N { get; set; }
        private int A { get; set; }
        private int B { get; set; }

        private int[,] matrix;
        private Random random = new Random();

        public MatrixClass(int n, int a, int b)
        {
            N = n;
            A = a;
            B = b;
            matrix = new int[N, N];
            FillMatrix();
        }

        private void FillMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[i, j] = random.Next(A, B + 1);
                }
            }
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write($"{matrix[i, j],5}");
                }
                Console.WriteLine();
            }
        }

        public int CountOdd()
        {
            int count = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        count++;
                }
            }
            return count;
        }
    }
}
