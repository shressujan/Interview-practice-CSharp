using System;

namespace Encapsulation
{
    class Triangle: Shape
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle
            {
                Type = "2D"
            };
                
            // t.type = "2D"; Cannot do this because the variable is not public in the parent class
            
            Console.WriteLine($"The object is of type {t.Type}");

        }
    }
}