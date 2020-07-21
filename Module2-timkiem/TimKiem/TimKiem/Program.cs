using System;
using System.Net.NetworkInformation;

namespace TimKiem
{
    class Program
    {
        private static int[] array; 
        static void Main(string[] args)
        {

            Timkiem timkiem = new Timkiem();
            string choice = "";
            while(choice != "5")
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Create Array");
                Console.WriteLine("2. IsSymmetry Array");
                Console.WriteLine("3. Selection Sort");
                Console.WriteLine("4. Find Array");
                Console.WriteLine("5. Exit ");
                Console.WriteLine("Enter your choice: ");
                choice = Console.ReadLine();
                Console.WriteLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("tao mang :");
                        Console.WriteLine("input n:");
                        int n = int.Parse(Console.ReadLine());
                        array = timkiem.CreateArray(n);
                        timkiem.PrintArray(array);
                        break;
                    case "2":
                        Console.WriteLine("kiem tra mang doi xung ");
                        if(timkiem.IsSymmetryArray(array)){
                            Console.WriteLine("Mang doi xung");
                        }
                        else
                        {
                            Console.WriteLine("Mang Ko doi xung");
                        }
                        timkiem.PrintArray(array);
                        break;
                    case "3":
                        Console.WriteLine("Sắp xếp mảng ");
                        timkiem.SelectionSort(array);
                        timkiem.PrintArray(array);
                        break;
                    case "4":
                        Console.WriteLine("Tìm kiếm mảng: ");
                        int number = int.Parse(Console.ReadLine());
                        Console.WriteLine( timkiem.Find(array, number));
                        timkiem.PrintArray(array);
                        break;
                    case "5":
                        Console.WriteLine("Exit ");
                        break;
                }

            }
         
        }
        
    }
}
