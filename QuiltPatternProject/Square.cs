using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public class Square : Shape
    {
        public int Side1 { get; set; }
        public Square(int side1, string color1)
        {
            Name = "Square";
            Color = color1;
            Side1 = side1;
        }

        public Square()
        {
        }

        public override int GetArea()
        {
            return Side1 * 2;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            
            Console.WriteLine($"It has a Side of {Side1}");
        }
    }
}
