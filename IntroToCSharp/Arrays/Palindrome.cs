namespace Arrays
{
    public class Palindrome
    {
        public bool CheckPalindrome(string value)
        {
            for (var i = 0; i < value.Length / 2; i++)
            {
                if (!value[i].Equals(value[value.Length - i - 1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}