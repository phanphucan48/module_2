using System;

namespace MaTran1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("nhập n1 ");
            //int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập n ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix1 = Tongmatran.CreateMatrix(n);
            int[,] matrix2 = Tongmatran.CreateMatrix(n);
            Console.WriteLine("Show matrix1:");
            Tongmatran.PrintMatrix(matrix1);
            Console.WriteLine("Show matrix2:");
            Tongmatran.PrintMatrix(matrix2);
            Console.WriteLine("Show SumMatrix:");
            Tongmatran.PrintMatrix(Tongmatran.Sum2Matrix(matrix1, matrix2));
            Console.WriteLine("Show product2Matrix:");
            Tongmatran.PrintMatrix(Tongmatran.product2Matrix(matrix1, matrix2));



        }

    }
}
