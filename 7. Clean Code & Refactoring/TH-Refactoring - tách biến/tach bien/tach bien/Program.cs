using System;

namespace tach_bien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(tach_bien.FizzBuzz(number));


        }
    }
}
