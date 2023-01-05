using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    public class Q004 : IEulerProblem
    {
        public string Solve()
        {
            int num, max = 0, iIndex = 0, jIndex = 0;
            for (int i = 999; i >= 100; i--)
                for (int j = 999; j >= 100; j--)
                {
                    num = i * j;
                    if (isPalindrome(num) && num > max)
                    {
                        max = num;
                        iIndex = i;
                        jIndex = j;
                    }
                }
            return $"Largest palindrome is: {max}, i: {iIndex}, j: {jIndex}";
        }

        private bool isPalindrome(int num)
        {
            int tempValue = num;
            int reverse = 0;
            while (tempValue > 0)
            {
                reverse = reverse * 10 + tempValue % 10;
                tempValue = tempValue / 10;
            }

            return reverse == num;
        }
    }
}
