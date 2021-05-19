using System;

namespace Arrays
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] num = {1,2,3,4,5,6,7,8,9,10};
            var sum = 0;
            foreach (var val in num)
            {
                sum += val;
                Console.WriteLine(val);
            }
            
            Console.WriteLine($"The sum of the array of numbers is {sum}");
            
            
            Console.WriteLine("Check palindrome");
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            Palindrome p = new Palindrome();
            Console.WriteLine(p.CheckPalindrome(word)
                ? $"The input word {word} is a palindrome"
                : $"The input word {word} is not a palindrome");
        }
    }
}