using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public class Square : Shape
    {
        public decimal side1;
        private string Name;

        public string Color { get; private set; }
        public decimal sie1 { get; private set; }

        public Square(string color, decimal side)
        {
            Name = "Square";
            Color = color;
            side1 = side;
        }
    }
}
