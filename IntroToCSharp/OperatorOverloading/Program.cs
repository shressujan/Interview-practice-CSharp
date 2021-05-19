using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Box a = new Box
            {
                length = 10,
                breadth = 10,
                height = 10
            };
            Box b = new Box
            {
                length = 20,
                breadth = 20,
                height = 20
            };

            Box c = a + b;
            Console.WriteLine($"Box c Length: {c.length}, Breadth: {c.breadth}, Height: {c.height}");
        }
    }
}