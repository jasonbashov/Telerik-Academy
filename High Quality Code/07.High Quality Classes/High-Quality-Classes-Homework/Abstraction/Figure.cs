using System;

namespace Abstraction
{
    abstract class Figure
    {
        private double height;
        private double width;

        public Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The width of the figure can not be less than 0!");
                }
                this.width = value;
            }
        }
        public virtual double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The height of the figure can not be less than 0!");
                }
                this.height = value;
            }
        }

        public virtual double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public virtual double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
