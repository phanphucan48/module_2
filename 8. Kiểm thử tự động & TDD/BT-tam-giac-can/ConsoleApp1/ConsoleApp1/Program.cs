using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b, c;
            
            Console.WriteLine("nhập gia tri 3 canh tam giac...");
            Console.Write("nhập cạnh a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("nhập cạnh b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("nhập cạnh c: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine(TamGiac.LoaiTamGiac(a,b,c));








        }
    }
}
