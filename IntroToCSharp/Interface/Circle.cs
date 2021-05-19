using System;

namespace Interface
{
    public class Circle: Shape
    {
        private double radius;

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double calculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double calculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}