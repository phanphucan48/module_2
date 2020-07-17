using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            PhoneBook phoneBook = new PhoneBook();
            phoneBook.insertPhone("an", "1234567");
            Console.WriteLine("Nhap so luong phoneBook muon Add: ");
           // int n = Int32.Parse(Console.ReadLine());
            //for(int i = 0; i < n; i++)
            //{
                Console.WriteLine("nhap ten");
                string name = Console.ReadLine();
                Console.WriteLine("nhap phone");
                string phone = Console.ReadLine();
                phoneBook.insertPhone(name, phone);
            //}
            
            //Console.WriteLine(phoneBook.Phonelist[0].ToString());
            for (int i = 0; i < phoneBook.Phonelist.Count; i++) {
                Console.WriteLine(phoneBook.Phonelist[i].ToString());

            }





        }
    }
}
