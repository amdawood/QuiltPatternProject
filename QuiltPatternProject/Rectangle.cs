using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public class Rectangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }

        public Rectangle(int side1, int side2, string color1)
        {
            Name = "Rectangle";
            Color = color1;
            Side1 = side1;
            Side2 = side2;
        }

        public Rectangle()
        {
        }

        public override int GetArea()
        {
            return Side1 * Side2;
        }

        public override void GetInfo()
        {
            base.GetInfo();

            Console.WriteLine($"It has sides of {Side1} and {Side2}");
        }
    }
}
