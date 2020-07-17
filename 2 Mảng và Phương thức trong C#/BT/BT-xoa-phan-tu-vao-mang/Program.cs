using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 5, 7, 8 };
            int[] b = new int[a.Length - 1];
            int index = 0;
            bool tontai = false;
            Console.WriteLine("Nhap phan tu muon xoa");
            int x = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    Console.WriteLine("co phan tu x trong mang");
                    index = i;
                    tontai = true;
                }
            }
            if (tontai == true)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (i < index)
                    {
                        b[i] = a[i];
                    }
                    else if (i >= index)
                    {
                        b[i] = a[i + 1];
                    }
                }
                foreach (int tam in b)
                {
                    Console.Write(tam + " ");
                }
            }
            else
            {
                Console.WriteLine("khong ton tai trong mang");
            }
        }
    }
}
