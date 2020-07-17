using System;
using System.Collections;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrpersons = new ArrayList(); // khoi tao mang arraylist trong 
                                                    // ArrayList MyArray2 = new ArrayList(5); // khoi tao mang co capacity ban dau la 5
                                                    // khoi tao mot arraylist bang voi kich thuoc arraylist2
                                                    // sao chep toan bo phan tu trong myarray2 vao array3 
                                                    //ArrayList MyArray3 = new ArrayList(MyArray2);
                                                    // ArrayList MyArray4 = MyArray2;

            //  them 3 phan tu vao danh sach 
            arrpersons.Add(new Person("Phan Phuc An", 30));
            arrpersons.Add(new Person("Nguyen Van Tung", 23));
            arrpersons.Add(new Person("My linh", 27));
            // in ra danh sach ban dau 
            Console.WriteLine("Danh sach ban dau : ");
            foreach (Person item in arrpersons)
            {
                Console.WriteLine(item.ToString());
            }
            // tuoi tang dan 
            arrpersons.Sort();


        }
    }
}
