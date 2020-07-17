﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModefileDemo
{ public class StudentClass
    {
        public static void Main()
        {
            ClassStudent student1 = new ClassStudent(12, "Nguyen Hue", "Tp .Hue", 24);
            ClassStudent student2 = new ClassStudent();
            student2.Name = "Nguyen The My";
            student2.Address = "Tp Hue";
            student2.Id = 12;
            student2.Age = 26;
            student2.ToString();
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student2.ToString());


        }
    }

    class ClassStudent
    {
        private int id;
        private string name;
        private string address;
        private int age;
        public ClassStudent() { }
        public ClassStudent(int _id, string _name, string _address, int _age)
        {
            this.id = _id;
            this.name = _name;
            this.address = _address;
            this.age = _age;
        }
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Address
        {
            get => address;
            set => address = value;
        }
        public int Age
        {
            get => age;
            set => age = value;
        }
        public override string ToString()
        {
            return "Id : " + id + " Name : " + name + " Address : " + address + " Age : " + age;
        }
    }

}
