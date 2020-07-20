using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Matran3
{
    public class MyMatrix
    {
        public int[,] CreateMatrix(int n)
        {
            Random random = new Random();
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(20, 60);
                }
            }
            return matrix;
        }
        public int songuyen()
        {
            bool ketqua;
            int v;
            do
            {
                Console.WriteLine("enter number : ");
                ketqua = int.TryParse(Console.ReadLine(), out v);

            }
            while (!ketqua || v < 20 || v > 60);

            return v;

        }
        public int[,] giatri( int[,] matrix)
        {
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] % 5 != 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
            return matrix;
        }
        public void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
