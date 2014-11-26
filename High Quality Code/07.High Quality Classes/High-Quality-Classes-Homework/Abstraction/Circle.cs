using System;

namespace Abstraction
{
    class Circle : Figure
    {
        private double radius;
        public Circle(double radius)
            : base(0, 0)
        {
            this.Radius = radius;
        }

        public double Radius 
        {
            get
            {
                return this.radius;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The radius of the circle can not be less than 0!");
                }
                this.radius = value;
            }
        }

        public override double Height
        {
            get
            {
                throw new ArgumentException("Circle does not have Height");
            }
        }
        public override double Width
        {
            get
            {
                throw new ArgumentException("Circle does not have Width");
            }
        }
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
