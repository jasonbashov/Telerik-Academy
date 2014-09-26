using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Geometry
{
    public class Circle : Shape
    {
        public Circle(double radius)
            : base(radius,radius)
        {
        }

        public override double CalculateSurface()
        {
            return (Math.PI * this.Width * this.Height);
        }
    }
}
