using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace ConsoleApp1.Service
{
    public class FizzBuzz
    {
        public string BuzzFizz(int number)
        {
            string tam = "";
            if (number % 3 ==0)
            {
                tam = "Fizz";
            }
            if (number % 5 == 0)
            {
                tam += "Buzz";
            }
            return tam;
        }

    }
}
