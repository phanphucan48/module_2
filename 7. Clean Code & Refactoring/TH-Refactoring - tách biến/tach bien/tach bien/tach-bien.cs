﻿using System;
using System.Collections.Generic;
using System.Text;

namespace tach_bien
{
    class tach_bien
    {
        public static string FizzBuzz(int number)
        {
            bool isFizz = number % 3 == 0;
            bool isBuzz = number % 5 == 0;
            if (isFizz && isBuzz)
            {
                return "FizzBuzz";
            }
            if (isFizz)
            {
                return "Fizz";
            }
            if (isBuzz)
            {
                return "Buzz";
            }
            return number + "";
        }
    }
}
