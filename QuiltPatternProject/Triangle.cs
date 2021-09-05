using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public class Triangle : Shape
    {
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

        public Triangle(int side1, int side2, int side3, string color1)
        {
            Name = "Triangle";
            Color = color1;
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public Triangle()
        {
        }

        public override int GetArea()
        {
            int s = (Side1 + Side2 + Side3) / 2;
            int x = s - Side1;
            int y = s - Side2;
            int z = s - Side3;
            int answer = Convert.ToInt32(Math.Sqrt(s * x * y * z));

            return answer;
        }

        public override void GetInfo()
        {
            base.GetInfo();

            Console.WriteLine($"It has sides of {Side1}, {Side2}, and {Side3}");
        }
    }
}
