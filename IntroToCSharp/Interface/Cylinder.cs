using System;

namespace Interface
{
    public class Cylinder: Shape, Volume
    {
        private double radius;
        private double height;

        public double Radius
        {
            get => radius;
            set => radius = value;
        }

        public double Height
        {
            get => height;
            set => height = value;
        }

        public double calculateArea()
        {
            double area = (2 * Math.PI * radius * height) + (2 * Math.PI * radius * radius);
            return area;
        }

        public double calculateVolume()
        {
            return Math.PI * radius * radius * height;
        }

        public double calculatePerimeter()
        {
            return 2 * Math.PI * radius;
        }
    }
}