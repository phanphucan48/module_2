using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModefileDemo
{

    public class Car
    {

        private string name;
        private string engine;
        public static int numberOfCars;
        public Car(string name, string engine)
        {
            this.name = name;
            this.engine = engine;
            numberOfCars++;
        }
    }
}
