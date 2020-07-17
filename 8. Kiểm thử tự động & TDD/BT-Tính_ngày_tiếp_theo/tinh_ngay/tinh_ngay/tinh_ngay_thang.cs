using System;
using System.Collections.Generic;
using System.Text;

namespace tinh_ngay
{
    public class Tinh_Ngay_Thang
    {
        public static void PrintNextDay(int date , int month, int year)
        {
            int new_date;
            int new_month;
            int new_year;
            if (date < DayInMonth(month, year))
            {
                new_date = date + 1;
                Print(new_date, month, year);
            }
            else if (date == DayInMonth(month,year)) 
            {
                new_date = 1;
                if (month < 12)
                {
                    new_month = month + 1;
                    Print(new_date, new_month, year);
                }
                else if (month == 12)
                {
                    new_month = 1;
                    new_year = year + 1;
                    Print(new_date, new_month, new_year);
                }
                else
                {
                    Console.WriteLine("Enter Wrong!!!!!!");
                }
            }
        }

        public static bool IsLeapYear(int year)
        {
            bool isDivisibleBy4 = year % 4 == 0;
            if (isDivisibleBy4)
            {
                bool isDivisibleBy100 = year % 100 == 0;
                if (isDivisibleBy100)
                {
                    bool isDivisibleBy400 = year % 400 == 0;
                    if (isDivisibleBy400)
                    {
                        return true;
                    }
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public static int DayInMonth(int month, int Year)
        {
            int day_in_month;
            switch (month)
            {
                case 2:
                    if (IsLeapYear(Year))
                    {
                        day_in_month = 29;
                    }
                    else
                    {
                        day_in_month = 28;
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    day_in_month = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    day_in_month = 30;
                    break;
                default:
                    day_in_month=0;
                    break;
            }
            return day_in_month;
        }
        public static void Print(int date , int month , int year)
        {
            Console.WriteLine($"tomorow(dd/mm/yyyy):{date}/{month}/{year}");
        }
    }
}
