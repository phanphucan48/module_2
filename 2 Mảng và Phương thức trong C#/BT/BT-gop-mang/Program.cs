using System;

namespace BT_gop_mang
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] mangso1 = { 1, 2, 3, 4, 5 };
            int[] mangso2 = { 6, 7, 8, 9, 10 };
            int[] mangso3 = new int[mangso1.Length + mangso2.Length];
            for (int i = 0; i < mangso1.Length; i++)
            {
                mangso3[i] = mangso1[i];
            }
            for (int i = 0; i < mangso2.Length; i++)
            {
                mangso3[i + mangso1.Length] = mangso2[i];
            }
            for (int i = 0; i < mangso3.Length; i++)
            {
                Console.Write(mangso3[i] + " ");
            }
        }

    }
}
