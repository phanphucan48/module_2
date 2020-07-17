﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModefileDemo
{
    class phuong_trinh_bac_2
    {
        public static void Main()
        {
            QuadraticEquation phuongtrinh = new QuadraticEquation(7, -3, -4);
            phuongtrinh.giai();
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
                    Console.WriteLine($"phuong trinh co 2 nghiem : {GetRoot1()} va {GetRoot2()}");
                }
                else if (GetDiscriminant() == 0)
                {
                    Console.WriteLine($"phuong trinh co 1 nghiem : {GetRoot1()}");

                }
                else Console.WriteLine("The equation has no roots");



            }
        }
    }
}
