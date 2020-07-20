using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace MaTran1
{
    public  class Tongmatran
    {
       public  static int[,] CreateMatrix(int n)
        {
            Random rnd = new Random();
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j =0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 40);
                }
            }
            return matrix;
        }
       public  static int[,] Sum2Matrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return matrix;
        }
        public  static void PrintMatrix (int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] product2Matrix(int[,] matrix1, int[,] matrix2)
        {
            int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix1[i, j] * matrix2[i, j];
                }
            }
            return matrix;
        }

    }
}
