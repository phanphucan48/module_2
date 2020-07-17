using System;

namespace Poin2D
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("nhập giá trị x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("nhập giá trị y");
            y = float.Parse(Console.ReadLine());
            Poin2 p2d = new Poin2(x, y);
            Console.WriteLine(p2d);


            float z;
            Console.WriteLine("nhập giá trị x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("nhập giá trị y");
            y = float.Parse(Console.ReadLine());
            Console.WriteLine("nhập giá trị z");
            z = float.Parse(Console.ReadLine());
            Poin3 P3d = new Poin3(x, y, z);
            Console.WriteLine(P3d);


        }
    }
}
