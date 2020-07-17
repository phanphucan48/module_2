using System;
using System.Collections.Generic;
using System.Text;

namespace Poin2D
{
    public class Poin2
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Poin2()
        {

        }
        public Poin2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float GetX
        {
            get => x;
            set => x = value;
        }
        public float GetY
        {
            get => y;
            set => y = value;
        }
        public void SetXY(float newX, float newY)
        {
            x = newX;
            y = newY;
        }
        public float[] GetXY()
        {
            float[] arr = new float[2] { x, y };
            return arr;
        }
        public override string ToString()
        {
            return $"Poin2D with X={x} and Y={y}";


        }

    }
    public class Poin3 : Poin2
    {
        public float z = 0.0f;
        public Poin3()
        {

        }
        public Poin3(float z)
        {
            this.z = z;
        }
        public Poin3(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }
        public float GetZ
        {
            get => z;
            set => z = value;

        }
        public void SetXYZ(float newX, float newY , float newZ)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        public float[] GetXYZ()
        {
            float[] arr1 = new float[3] { x, y, z };
            return arr1;
        }
        public override string ToString()
        {
            return $"Point 3D with z={z} ,which is a subclass of "+ base.ToString();
        }
    }
}
