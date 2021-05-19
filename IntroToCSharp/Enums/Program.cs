using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Season.Fall);
            Console.WriteLine((int)Season.Fall);
            Console.WriteLine(Season.Fall.GetDescription());
        }
    }
}