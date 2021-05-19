using System;

namespace Inheritance
{
    class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "John",
                LastName = "Doe",
                Sex = 'M',
                StudentId = 1,
                Department = "CS"
            };

            Console.WriteLine(student.ToString());
        }
    }
}