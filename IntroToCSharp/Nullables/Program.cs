using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num = null; //Example of nullable variable
            bool? isMale = null; // bool isMale = null would give compiler error without the Nullable.
            Console.WriteLine($"The Value of num is {num}");
            Console.WriteLine($"The value of isMale is {isMale}");
        }
    }
}