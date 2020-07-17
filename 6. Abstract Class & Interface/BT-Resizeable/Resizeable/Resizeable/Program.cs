using System;

namespace Resizeable
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5, "green", true);
            Console.WriteLine(circle);
            circle.Resize(5);
            Console.WriteLine($"area circle :{circle.getArea()}");
            Rectangle rectangle = new Rectangle(3, 10);
            Console.WriteLine(rectangle);
            rectangle.Resize(10);
            Console.WriteLine($"area rectangle :{rectangle.getArea()}");

        }
    }
}
