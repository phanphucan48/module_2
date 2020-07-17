using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Service
{
    public class TamGiac
    {
        public string LoaiTamGiac(double  a, double b  ,double c)
        {
            bool isTriangle = (a + b > c && a + c > b && b + c > a);
            if (a == b && b == c)
            {
                return ("Tam Giác Đều");
            } else if ((a == c || b == c || a == c) && isTriangle)
            {
                return ("Tam Giác Cân");
            }else if (isTriangle)
            {
                return ("Tam Giác Thường");
            } return ("Không Phải Tam Giac");

            
            
        }
    }
}
