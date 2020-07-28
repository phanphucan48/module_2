using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.IO;
using System.Net;

namespace Module2_File
{
    public class FileName
    {
        public int[,] Matrix(int r, int c)
        {
            int[,] matrix = new int[r, c];

            Random random = new Random();
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    matrix[i, j] = random.Next(10, 70);

                }
            }

            return matrix;


        }
        public int SumMatrix(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];

                }
            }
            return sum;
        }
        
        public void ReadFile(string path, ref int[,] array)
        {
            List<string[]> list = new List<string[]>();
            using (StreamReader sr = File.OpenText(path))
            {
                {
                    var line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] data = line.Split(' ');
                        list.Add(data);
                    }
                    array = new int[list.Count, list[0].Length];
                    for(int i = 0; i < list.Count; i++)
                    {
                        for(int j = 0; j < list[i].Length; j++)
                        {
                            array[i, j] = Int32.Parse(list[i][j]);
                        }
                       
                    }
                }
            }


        }
        public void NewWriteFile(string path, int[,] array)
        {
            using(StreamWriter sw = File.CreateText(path))
            {
                int sum = 0;
                for(int i = 0; i < array.GetLength(0); i++)
                {
                    for(int j = 0; j < array.GetLength(1); j++)
                    {
                        sum += array[i, j];
                    }
                }
                sw.WriteLine(sum);
                int countSNT = 0;
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        if(CheckSNT(array[i, j]) == true) {
                            countSNT++;
                        }
                    }
                }
                sw.WriteLine(countSNT);

            }
        }
        public bool CheckSNT(int number)
        {
           
            
            if (number < 2)
            {
                return false;
            }else if(number == 2)
            {
                return true;
            }
            else
            {
                for(int i = 2; i < number; i++)
                {
                    if(number % i == 0)
                    {
                        return false;
                    }
                }              
                return true;
            }
        }
       public int borderline(int [,] matrix) 
        {
            int sum = 0;
            for ( int i = 0 ; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, 0] + matrix[i,matrix.GetLength(1)-1];
            }
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                sum += matrix[0, j] + matrix[matrix.GetLength(0)-1,j];
            }
            return sum; 
        }
        //public int productTheer(int [,] matrix)
        //{
        //    for (int i = 0; i < matrix.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(1); j++) 
        //        { 

        //        }
        //    }
        //}





    }
}
