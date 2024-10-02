namespace Task.Extensions
{
    internal static  class IntPolindromeExtension
    {
        public static bool IsPolindrome(this int number)
        {
            int temp = number;
            int rev = 0;
            while (number > 0)
            {
                int digit = number % 10;
                rev = rev * 10 + digit;
                number /= 10;
            }
            return temp == rev;
        }
    }
}
