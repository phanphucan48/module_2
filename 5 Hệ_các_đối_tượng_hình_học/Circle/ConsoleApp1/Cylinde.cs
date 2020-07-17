using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
        public class Circle
        {
            private double radius = 1.0;
            private string color = "green";
            public Circle()
            {

            }

            public Circle(double radius, string color)
            {
                this.radius = radius;
                this.color = color;
            }
            public double GetRadius
            {
                get => radius;
                set => radius = value;
            }
            public string Getcolor
            {
                get => color;
                set => color = value;
            }
            public double GetAria()
            {
                return radius * radius * Math.PI;
            }

            public override string ToString()
            {
                return $"A Circle with radius {GetRadius}, color {Getcolor}";
            }
            public class Cylinde : Circle
            {
                private double heigth;

                public Cylinde()
                {

                }
                public Cylinde(double heigth)
                {
                    this.heigth = heigth;
                }
                public Cylinde(double heigth, double radius, string color) : base(radius, color)
                {
                    this.heigth = heigth;
                }
                public double Getheigth
                {
                    get => heigth;
                    set => heigth = value;
                }
                public double Getvolume()
                {
                    return GetAria() * this.heigth;
                }

            }
        }
    }