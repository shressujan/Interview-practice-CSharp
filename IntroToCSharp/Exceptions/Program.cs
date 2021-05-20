using System;

namespace Exceptions
{
    class Program
    {
        private static int? division()
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

        private static bool CheckEligibleToVote(int age)
        {
            switch (age)
            {
                case < 0:
                    throw new CustomException("Invalid Age");
                case > 0 and < 18:
                    return false;
                default:
                    return true;
            }
        }
        
        static void Main(string[] args)
        {
            var val = Program.division();
            Console.WriteLine($"Division value: {val ?? 0}"); //Using null coalescing kind of like orelse
                                                              //if null return 0 otherwise return actual value
                                                              
                                                              
             /* Check eligible to vote and custom exception */
             Console.WriteLine("\n Checking Voters Eligibility");
             const int age = -1;
             try
             {
                Console.WriteLine(Program.CheckEligibleToVote(age) ?  "Eligible to vote" : "Not Eligible to vote");
             }
             catch (CustomException e)
             {
                 Console.WriteLine(e.Message);
             }
        }
    }
}