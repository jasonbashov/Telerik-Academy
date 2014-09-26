namespace _01.Geometry
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private double width;
        private double height;

        public Shape(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get { return this.width; } }
        public double Height { get { return this.height; } }

        public abstract double CalculateSurface();
    }
}
