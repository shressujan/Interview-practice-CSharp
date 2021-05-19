using System;

namespace Conditions
{
    class Program
    {
        private static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age: ");
            string userInput = Console.ReadLine();
            age = Convert.ToInt32(userInput);

            if (age > 18)
            {
                Console.WriteLine("You are eligible to vote");
            }
            else
            {
                Console.WriteLine("You are not eligible to vote");
            }
        }
    }
}