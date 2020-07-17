using System;

namespace MoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y;
            Console.WriteLine("nhap gia tri x");
            x = float.Parse(Console.ReadLine());
            Console.WriteLine("nhap gia tri y");
            y = float.Parse(Console.ReadLine());
            Poin poin = new Poin(x, y);
            Console.WriteLine(poin);
            
        }
    }
}
