using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Matran3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMatrix matrix = new MyMatrix();
            var matrix1 = matrix.CreateMatrix(5);
            matrix.PrintMatrix(matrix1);
            Console.WriteLine();
            matrix.giatri( matrix1);
            matrix.PrintMatrix(matrix1);
        }
    }
}
