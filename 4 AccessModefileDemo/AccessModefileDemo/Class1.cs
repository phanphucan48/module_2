using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement
{
   class Program
    {
        public static ProductService ProductService = new ProductService();
        static void Main(string[] args)
        {
            byte chon = 5;
            while (chon != 0) 
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Add product");
                Console.WriteLine("2. Edit product");
                Console.WriteLine("3. Delete product");
                Console.WriteLine("4. Show product");
                Console.WriteLine("0. Exit ");

                Console.WriteLine("Nhap chon :");
                chon = byte.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Add product");
                        CreateProduct();
                        break;
                    case 2:
                        Console.WriteLine("Edit product");
                        EditProduct();
                        break;
                    case 3:
                        Console.WriteLine("Delete product");
                        RemoveProduct();
                        break;
                    case 4:
                        Console.WriteLine("Show product");
                        ProductService.Show();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("xin loi ! khong co lua chon nay");
                        break;


                }
            }
            

            //CreateProduct();
            //CreateProduct();
            //CreateProduct();
            //ProductService.Show();
            //EditProduct();
            //ProductService.Show();
        }

        public static void CreateProduct()
        {
            //var product = new Product();
            //Console.Write("Product name: ");
            //product.Name = Console.ReadLine();
            //Console.Write("Product Code: ");
            //product.Code = Console.ReadLine();
            //Console.Write("Price: ");
            //product.Price = double.Parse(Console.ReadLine());
            //Console.Write("Product date: ");
            //product.Date = DateTime.Parse(Console.ReadLine());
            //Console.Write("Manufactory: ");
            //product.Manufactory = Console.ReadLine();
            Random rnd = new Random();
            var product = new Product()
            {
                Code = rnd.Next(1000,9999).ToString(),
                Date = DateTime.Parse("2020/07/07"),
                Manufactory = "USA",
                Name = "IP6",
                Price = 5000000
            };
            ProductService.Add(product);
        }

        public static void RemoveProduct()
        {
            Console.Write("Enter code: ");
            var code = Console.ReadLine();
            ProductService.Delete(code);
        }
        public static void EditProduct()
        {
            Console.WriteLine("New product");
            var newproduct = new Product();
            Console.Write("Product name: ");
            newproduct.Name = Console.ReadLine();
            Console.Write("Product Code: ");
            newproduct.Code = Console.ReadLine();
            Console.Write("Price: ");
            newproduct.Price = double.Parse(Console.ReadLine());
            Console.Write("Product date: ");
            newproduct.Date = DateTime.Parse(Console.ReadLine());
            Console.Write("Manufactory: ");
            newproduct.Manufactory = Console.ReadLine();

            // goi ham edit trong lop producservice
            ProductService.Edit(newproduct);
            
        }
    }
}
