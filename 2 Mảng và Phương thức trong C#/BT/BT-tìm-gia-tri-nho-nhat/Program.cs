using System;

namespace BT_tìm_gia_tri_nho_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mangsonguyen = { 7, 4, 78, 3, 9, 2 };
            int min = mangsonguyen[0];
            int index = 0;
            for (int i = 1; i < mangsonguyen.Length; i++)
            {
                if (min > mangsonguyen[i])
                {
                    min = mangsonguyen[i];
                    index = i + 1;
                }
            }
            Console.Write("gia tri nho nhat " + min + " o vi tri " + index);
            {

            }

        }

    }
}
