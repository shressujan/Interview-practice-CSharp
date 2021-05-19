using System;

namespace Polymorphism
{
    public class Output
    {
        public void Display(int age)
        {
            Console.WriteLine($"Age is {age}");
        }

        public void Display(double salary)
        {
            Console.WriteLine($"Salay is {salary}");
        }

        public void Display(string name)
        {
            Console.WriteLine($"Name is {name}");
        }
    }
}