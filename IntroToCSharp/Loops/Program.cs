using System;

namespace Loops
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("For Loop Demo");
            for (int j = 0; j < 10; j++)
            {
               Console.WriteLine(j);
            }

            Console.WriteLine("\nWhile Loop Demo");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            // Conditional exit loop demo using Do While
            Console.WriteLine("\nConditional exit Do While Loop Demo");
            Console.WriteLine("Enter X to Exit: ");
            string userInput = Console.ReadLine();
            do
            {
                Console.WriteLine("Enter X to Exit: "); 
                userInput = Console.ReadLine();
            } while (!userInput.Equals("X"));
        }
    }
}