using System;

namespace BT_xay_dung_lop_fan
{
    class Program
    {
        static void Main(string[] args)
        {
            FAN FAN1 = new FAN();
            FAN FAN2 = new FAN();
            FAN1.GetSpeed = 3;
            FAN1.Getradius = 10;
            FAN1.Getcolor = "yellow";
            FAN1.GetOn = true;
            FAN2.GetSpeed = 2;
            Console.WriteLine("FAN1: " + FAN1.Tostring());
            Console.WriteLine("FAN2: " + FAN2.Tostring());

        }
        public class FAN
        {
            const int SLOW = 1;
            const int MEDIUM = 2;
            const int FAST = 3;
            private int speed = SLOW;
            private bool On = false;
            private double radius = 5;
            private string color = "blue";

            public int GetSpeed
            {
                get => speed;
                set => speed = value;

            }
            public bool GetOn
            {
                get => On;
                set => On = value;
            }
            public double Getradius
            {
                get => radius;
                set => radius = value;
            }
            public string Getcolor
            {
                get => color;
                set => color = value;
            }
            public FAN()
            {

            }
            public string Tostring()
            {
                if (On)
                {
                    return $"speed: {speed}, color : {color}, radius : {radius} fan is on ";
                }
                else return $" color : {color}, radius : {radius} fan is off ";

            }
        }



    }
}
