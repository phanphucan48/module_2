using System;
using System.Collections.Generic;
using System.Text;

namespace Matrandaonguoc
{
     public class Matrandaonguoc
    {
        
        public int[,] CreateMatrix(int n , int m )
        {
            Random random = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(20, 60);
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
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public int[,] daokichngo(int[,] matrix)
        {
            int[,] matrix1 = new int[matrix.GetLength(1), matrix.GetLength(0)];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++) 
                {
                    matrix1[i, j] = matrix[j, i];

                }
            }
            return matrix1;

        }
    }
}

