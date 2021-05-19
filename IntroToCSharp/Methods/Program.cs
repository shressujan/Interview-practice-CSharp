using System;

namespace Methods
{
    class Program
    {
        private bool isEligibleToVote(int age)
        {
            return age >= 18;
        }
        
        private static void Main(string[] args)
        {
            int age;
            string input;
            Console.WriteLine("Enter age: ");
            input = Console.ReadLine();
            age = Convert.ToInt32(input);

            Program p = new Program();

            Console.WriteLine(p.isEligibleToVote(age) ? "You are eligible to vote" : "You are not eligible to vote");
        }
    }
}