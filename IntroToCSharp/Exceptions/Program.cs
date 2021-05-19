using System;

namespace Exceptions
{
    class Program
    {
        static int? division()
        {
            Console.WriteLine("Enter first num:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second num:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int div = 0;
            try
            {
                div = num1 / num2;
                return div;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by zero");
                return null;
            }
            finally //This execute even if there is an exception with return statement.
            {
                Console.WriteLine("Attempted Division");
            }
        }
        
        static void Main(string[] args)
        {

            int? val = Program.division();
            Console.WriteLine($"Division value: {val ?? 0}"); //Using null coalescing kind of like orelse
                                                              //if null return 0 otherwise return actual value
        }
    }
}