using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModefileDemo
{
    class Access_modifier
    {
        public static void Main()
        {
            Circle circle = new Circle(3);
            Console.WriteLine(circle.GetAria());
        }
    }
    class Circle
    {
        private double radius = 1.0;
        private string color = "red";

        public Circle()
        {

        }
        public Circle(double _radius)
        {
            this.radius = _radius;
        }
        public double GetRadius()
        {
            return radius;
        }
        public string GetColor()
        {
            return color;
        }
        public double GetAria()
        {
            return radius * radius * Math.PI;
        }
    }
}
