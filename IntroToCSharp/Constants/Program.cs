using System;

namespace Constants
{
    class Program
    {
        static void Main(string[] args)
        {

            const double mtEverestHeight = 8848.48;
            // MtEverestHeight = 100; MtEverestHeight variable is immutable because it's defined as constant.
            Console.WriteLine($"Height of Mount Everest is {mtEverestHeight} meters");
        }
    }
}