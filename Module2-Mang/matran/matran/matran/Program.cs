using System;
using System.Globalization;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap n");
            
            int n = int.Parse(Console.ReadLine());
            Random random = new Random();// tao ham random
            
            int[,] MaTran = new int[n,n];
            int sum = 0;
            int sumcheochinh = 0;

            for (int i =0; i< MaTran.GetLength(0); i++)

            {
                for ( int j = 0; j < MaTran.GetLength(0); j++)

                {
                    MaTran[i,j]= random.Next(10, 90);
                    Console.Write(MaTran[i, j] + " ");
                    if ( MaTran[i,j] %2 == 0)
                    {
                        sum += MaTran[i, j];
                        
                    } 
                    // tim duong cheo chinh
                    if(i == j)
                    {
                        sumcheochinh += MaTran[i, j];
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine("sum of even numbers of the matrix: " + sum);
            Console.WriteLine("Main total diagonal: " + sumcheochinh);

            int sumcheophu = 0;
            int m = MaTran.GetLength(0);
            for ( int i = 0; i < MaTran.GetLength(0); i++)
            {
                m = m - 1;
                sumcheophu += MaTran[i, m];
            }
            Console.WriteLine("sub-total diagonal : "+ sumcheophu);

            
            for (int i = 0; i < MaTran.GetLength(0); i++)
            { for (int j = 0; j <= i; j++)
                {
                    Console.Write(MaTran[i,j]);
                }

                Console.WriteLine();
            }
            Console.WriteLine();
            for (int t = 0; t < MaTran.GetLength(0); t++)// tam giac tren 
            {
                for (int j = 0; j <= t; j++)
                {
                    Console.Write("   ");
                }
                for (int j = t; j < MaTran.GetLength(0); j++)
                {
                    Console.Write(MaTran[t, j]+" ");
                }
                Console.WriteLine();
            }







        }
    }
}
