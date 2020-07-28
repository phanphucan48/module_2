using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Module2_File
{
    class Program
    {
        static void Main(string[] args)
        {
            FileName newfile = new FileName();
           // newfile.Matrix(4, 6);
            //int[,] matrix = newfile.Matrix(4, 6);
            int[,] array = new int[0, 0];
            var input = $@"C:\Users\Admin\source\repos\Module2-File\Module2-File\Data\InputData.txt";
            var output = @"C:\Users\Admin\source\repos\Module2-File\Module2-File\Data\OutputData.txt";
            //newfile.ReadFile(input,ref array);
            //newfile.NewWriteFile(output, array);
            //newfile.
            List<string[]> data = new List<string[]>();
            using (StreamReader sr = File.OpenText(input))
            {
                //Console.WriteLine(sr.ReadToEnd());
                var line = string.Empty;
                int number = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    number += 1;
                    //Console.WriteLine($"Line {number} : {line.ToUpper()}");
                    data.Add(line.ToUpper().Split(" "));
                }

            }
            Console.WriteLine(data);
            int[,] matrix1 = new int[3, 4];
            for (int i = 0; i < data.Count; i++)
            {
                for (int j = 0; j < data[i].Length; j++)
                {
                    matrix1[i, j] = int.Parse(data[i][j]);
                }
            }

         
            for ( int i = 0; i < matrix1.GetLength(0); i++)
            {
                for ( int j =0; j < matrix1.GetLength(1); j++)
                {
                    Console.Write(matrix1[i, j]+ " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("sum matrix :" + newfile.SumMatrix(matrix1));
            int dem = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (newfile.CheckSNT(matrix1[i, j]))
                    {
                        dem++;
                    }
                }
            }

            Console.WriteLine($"số lượng số lượng nguyên tố : {dem}");
            int Count = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i,j] %2 !=0)
                    {
                        Count++;
                    }
                }
            }
            Console.WriteLine($"số lẽ trong ma trận : { Count}");

            Console.WriteLine($"tổng gia tri duong bien : {newfile.borderline(matrix1)}");
            Console.WriteLine("hien thi ma tran nhan 3 :");

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                   
                    Console.Write(matrix1[i, j]*3 + "\t");
                }
                Console.WriteLine();
            }
            //newfile.sum2so(4, 5);

          


            using (StreamWriter sw = File.CreateText(output))
            {
                sw.WriteLine("tong gia tri ma tran: " + newfile.SumMatrix(matrix1));
                sw.WriteLine("so luong so nguyen to trong ma tran: " + dem );
                sw.WriteLine("so luong so le trong ma tran: " + Count );
                sw.WriteLine("tổng đường biên : " + newfile.borderline(matrix1));
                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                   
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {

                        sw.Write(matrix1[i, j] * 3 + "\t");
                        
                    }
                    sw.WriteLine();
                }
                Console.WriteLine();




            }
        }
    }
}









































//string path = @"C:\Users\Admin\Desktop\demo\bai-tap-file\InputData.txt";
//StreamReader sr = File.OpenText(path);
//string s;
//while ((s = sr.ReadLine()) != null)
//{
//    Console.WriteLine(s);
//}




//int r = 3;
//int c = 4;
//file newfile = new file();
//var arr = newfile.matrix(r, c);
//for(int i = 0; i<arr.getlength(0); i++)
//{
//    for(int j = 0; j < arr.getlength(1); j++)
//    {
//        console.write(arr[i, j]+" ");
//    }
//    console.writeline();
//}
