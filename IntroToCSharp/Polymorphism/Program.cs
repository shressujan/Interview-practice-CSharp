using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 21;
            double salary = 90000.50;
            string name = "John doe";

            Output o = new Output();
            o.Display(age);
            o.Display(salary);
            o.Display(name);
        }
    }
}