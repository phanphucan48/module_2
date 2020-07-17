using System;

namespace tách_phương_thức
{
    class Program
    {
        static void Main(string[] args)
        {
            int radius;
            int heigth;
            Console.WriteLine("enter the radius");
            radius = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the height");
            heigth = int.Parse(Console.ReadLine());
            Console.WriteLine(CylinderDemo.GetPerimeter(radius));
            Console.WriteLine(CylinderDemo.GetbaseArea(radius));
            Console.WriteLine(CylinderDemo.Getvolume(radius, heigth));




        }
    }
}
