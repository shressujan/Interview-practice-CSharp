using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle()
            {
                Radius = 10
            };

            Cylinder cl = new Cylinder()
            {
                Radius = 5,
                Height = 10
            };
            
            Console.WriteLine("Circle");
            Console.WriteLine("Area: " + c.calculateArea());
            Console.WriteLine("Perimeter: " + c.calculatePerimeter());
            
            Console.WriteLine("\nCylinder");
            Console.WriteLine("Area: " + cl.calculateArea());
            Console.WriteLine("Perimeter: " +cl.calculatePerimeter());
            Console.WriteLine("Volume: " +cl.calculateVolume());
        }
    }
}