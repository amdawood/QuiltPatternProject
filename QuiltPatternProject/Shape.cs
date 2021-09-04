using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltPatternProject
{
    public abstract class Shape
    {
        string name = "Shape Name";
        string color = "Shape Color";

        public decimal GetArea(decimal area)
        {
            return area;
        }
    }
}
