using System;

namespace BT_tinh_phuong_trinh_bac_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QuadraticEquation pt = new QuadraticEquation(1, 3, -4);
            pt.giai();
        }
        public class QuadraticEquation
        {
            private double a;
            private double b;
            private double c;
            public QuadraticEquation(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public double GetA()
            {
                return this.a;
            }
            public double GetB()
            {
                return this.b;
            }
            public double GetC()
            {
                return this.c;
            }
            public double GetDiscriminant()
            {
                return b * b - 4 * a * c;
            }
            public double GetRoot1()
            {
                return (-b + (Math.Sqrt(GetDiscriminant()))) / (2 * a);
            }
            public double GetRoot2()
            {
                return (-b - (Math.Sqrt(GetDiscriminant()))) / (2 * a);
            }
            public void giai()
            {
                if (GetDiscriminant() >= 0)
                {
                    Console.WriteLine($" pt co 2 nghiem: {GetRoot1()} và {GetRoot2()}");
                }
                else if (GetDiscriminant() == 0)
                {
                    Console.WriteLine($" pt co 1 nghiem: {GetRoot1()}");
                }
                else Console.WriteLine(" pt vo nghiem");
            }

        }
    }
}
