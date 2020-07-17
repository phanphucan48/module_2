using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            Circle circle = new Circle();
            Console.WriteLine(circle);


            //Shape shape = new Shape();
            //Console.WriteLine(shape);
            //Console.WriteLine("Hello World!");
            //shape = new Shape("red", false);
            //Console.WriteLine(shape);
        }
    }
}
//    public class Shape
//    {
//        private string color = "green";
//        private bool filled = true;

//        public Shape()
//        {

//        }
//        public Shape(string color, bool filled)
//        {
//            this.color = color;
//            this.filled = filled;
//        }
//        public string Getcolor
//        {
//            get => color;
//            set => color = value;
//        }
//        public bool Getfilled
//        {
//            get => filled;
//            set => filled = value;
//        }
//        public override string ToString()
//        {
//            return $" A Shape with color of {color} and {((filled) ? "filled" : "not filled")} ";
//        }

//    }
//    public class Circle : Shape
//    {
//        private double radius = 1.0;
//        public Circle()
//        {

//        }
//        public Circle(double radius)
//        {
//            this.radius = radius;
//        }
//        public Circle(double radius, string color, bool filled) : base(color, filled)
//        {
//            this.radius = radius;
//        }
//        public double GetRadius
//        {
//            get => radius;
//            set => radius = value;
//        }
//        public double GetAria()
//        {
//            return radius * radius * Math.PI;
//        }
//        public double GetPerimeter()
//        {
//            return 2 * radius * Math.PI;
//        }
//        public override string ToString()
//        {
//            return $"A Circle with {GetRadius}, which is a subclass of {base.ToString()}";
//        }


//    }
//    public class Rectangle : Shape
//    {
//        private double width = 1.0;
//        private double length = 1.0;

//        public Rectangle()
//        {

//        }
//        public Rectangle(double width, double length)
//        {
//            this.width = width;
//            this.length = length;
//        }
//        public Rectangle(double width, double length, String color, bool filled) : base(color, filled)
//        {
//            this.width = width;
//            this.length = length;
//        }
//        public double GetWidth
//        {
//            get => width;
//            set => width = value;
//        }
//        public double Getlength
//        {
//            get => length;
//            set => length = value;
//        }
//        public double GetArea()
//        {
//            return width * this.length;
//        }
//        public double GetPerimeter()
//        {
//            return 2 * (width + this.length);
//        }
//        public override string ToString()
//        {
//            return $"A Rectangle with width={GetWidth}+and length{Getlength}+, which is a subclass of{base.ToString()}";
//        }
//    }

//}
