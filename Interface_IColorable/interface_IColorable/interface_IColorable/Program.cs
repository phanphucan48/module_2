using System;
using System.Collections.Generic;
using System.Text;

namespace interface_IColorable
{
    class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(5, "green", true);
            Rectangle rectangle = new Rectangle(3, 5, "green", true);
            Shape[] shapes = new Shape[2];
            shapes[0] = square;
            shapes[1] = rectangle;
            
            foreach( var shape in shapes)
            {    
                Console.WriteLine($"{shape.Name()}\tArea: {shape.getArea()}");
                if (shape is IColorable)
                {
                    var icolorable = (Square)shape;
                    icolorable.HowToColor();
                }
                else Console.WriteLine("None color all four sides");
            }
        }
    }
}
