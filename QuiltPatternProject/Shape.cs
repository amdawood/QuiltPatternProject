using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public abstract class Shape
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public virtual void GetInfo()
        {
            Console.WriteLine($"\n**This is a {Name}");
            Console.WriteLine($"**The color of the shape is {Color}");
        }

        public abstract int GetArea();

    }
}
