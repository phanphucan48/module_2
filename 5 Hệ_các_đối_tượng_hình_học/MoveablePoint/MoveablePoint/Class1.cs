using System;
using System.Collections.Generic;
using System.Text;

namespace MoveablePoint
{
    public class Poin
    {
        public float x = 0.0f;
        public float y = 0.0f;
        public Poin()
        {

        }
        public Poin(float x, float y)
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
            return $"Poin with X={x} and Y={y}";


        }
     
    }
}
