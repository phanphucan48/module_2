using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Phone // tao mot phuong thuc truu tuong abstract 
    {
        
        public abstract void insertPhone(string name, string phone);
        public abstract void removePhone(string name);
        public abstract void updatePhone(string name, string newphone);
        public abstract void searchPhone(string name);
        public abstract void sort();
        
        

    }
    public class UserPhone // tạo class userPhone để quản lý name , phone của người dùng nhập vào
    {
        public string name { get; set; }
        public string phone { get; set; }
        public override string ToString() // tao mot cai to string de goi gia tri 
        {
            return $"name = {name} | phone = {phone}";
        }
    }
    public class PhoneBook : Phone // tao mot lop kế thừa 
    {
        public List<UserPhone> Phonelist = new List<UserPhone>(); // tao mot list de luu tru du lieu 

        public override void insertPhone(string name, string phone)
        {
            bool check = true;
            for (int i = 0; i < Phonelist.Count; i++)
            {
                if (Phonelist[i].name == name)
                {
                    
                    if (Phonelist[i].phone != phone)
                    {
                        Phonelist[i].phone = Phonelist[i].phone + " :" + phone;

                    }
                    check = false;

                }
            }
            if (check)
            {
                UserPhone userPhone = new UserPhone(); // muon add vao so dien thoai phai tao mot doi tuong cua lop userPhone
                userPhone.name = name; // gan ten cua name userphone = name 
                userPhone.phone = phone;
                Phonelist.Add(userPhone);
            }
          
        }

        public override void removePhone(string name)
        {
           for( int i =0; i<Phonelist.Count; i++)
            {
                if(Phonelist[i].name == name)
                {
                    Phonelist.Remove(Phonelist[i]);
                }
            }
        }

        public override void searchPhone(string name)
        {
            throw new NotImplementedException();
        }

        public override void sort()
        {
            throw new NotImplementedException();
        }

        public override void updatePhone(string name, string newphone)
        {
            throw new NotImplementedException();
        }










        // tạo một lớp arraylist 
        //public ArrayList phoneList = new ArrayList();
        //public override void insertPhone(string name, string phone)
        //{
        //    bool check = true;
        //    for (int i = 0; i < phoneList.Count; i++)
        //    {
        //        if (phoneList[i] == name)
        //        {
        //            check = false;
        //            if (phoneList[i+1] != phone)
        //            {
        //                phoneList[i + 1] = phoneList[i + 1] + ": " + phone;
        //            }
        //        }
        //        i++;
        //    }


        //    if (check)
        //    {

        //        phoneList.Add(name);
        //        phoneList.Add(phone);

        //    }

    }

    //    public override void removePhone(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void searchPhone(string name)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void sort()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public override void updatePhone(string name, string newphone)
    //    {
    //        throw new NotImplementedException();
    //    }
       
    //}
}
