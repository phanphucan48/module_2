﻿using System;

namespace TH_su_dung_toan_tu
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float width;
            Console.Write("Enter width: ");
            width = float.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = float.Parse(Console.ReadLine());
            float area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }
}
