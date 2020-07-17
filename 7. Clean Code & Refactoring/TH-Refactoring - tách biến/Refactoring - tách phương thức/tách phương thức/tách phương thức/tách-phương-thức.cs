using System;
using System.Collections.Generic;
using System.Text;

namespace tách_phương_thức
{
    public class CylinderDemo
    {
        public static double Getvolume(int radius , int height)
        {
            double baseArea = GetbaseArea(radius);
            double perimeter = GetPerimeter(radius);
            double volume = perimeter * height + 2 * baseArea;
            return volume;
        }
        public static double GetPerimeter(int radius)
        {
            return 2 * Math.PI*radius;
        }
        public static double GetbaseArea(int radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
