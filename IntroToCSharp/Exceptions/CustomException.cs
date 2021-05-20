using System;

namespace Exceptions
{
    public class CustomException: Exception
    {
        public CustomException(): base("This is a custom exception message.")
        {
        }

        public CustomException(string? message) : base(message)
        {
        }
    }
}