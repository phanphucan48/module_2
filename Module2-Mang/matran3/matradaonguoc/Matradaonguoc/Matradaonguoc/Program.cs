using System;

namespace Matrandaonguoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrandaonguoc matrix = new Matrandaonguoc();
           
            var matrix1 = matrix.CreateMatrix(3,5);
            matrix.PrintMatrix(matrix1);
            Console.WriteLine();

            matrix.PrintMatrix(matrix.daokichngo(matrix1));



        }
    }
}
