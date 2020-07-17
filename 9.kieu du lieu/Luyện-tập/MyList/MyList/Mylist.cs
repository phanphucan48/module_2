using System;
using System.Collections.Generic;
using System.Text;

namespace MyList
{
    public class Person
    {
        private string name { get; set; }
        private int age;
        public string Name
        {
            get => this.name;
            set => this.name = value;
        }
        public int Age
        {
            get => this.age;
            set => this.age = value;
        }
        //tao 1 constructor co tham so de tien voi viec khoi tao nhanh doi tuong person voi ca gia tri cho san 
        public Person(string Name , int Age)
        {
            this.name = Name;
            this.age = Age;
        }
        // Override phuong thuc  Tostring de khi co the in ra object ra cho nhanh 
        public override string ToString()
        {
            return ("Name" + name + " Age " + age);
        }
        // tuoi tang dan 
        


    }
}
