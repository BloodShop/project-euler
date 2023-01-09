namespace csharp
{
    /// <summary>
    /// If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
    /// 
    /// If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
    /// 
    /// NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two)
    ///     contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.
    ///     The use of "and" when writing out numbers is in compliance with British usage.
    /// </summary>
    public class Q017 : IEulerProblem
    {
        public string Solve()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
                sum += i.ConvertNumberToEnglishUK().Length;
            return sum.ToString();
        }

        public static string[] ONENESS = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        public static string[] TENS = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
    }

    public static class IntEditor
    {
        public static string ConvertNumberToEnglishUK(this int i)
        {
            if (0 <= i && i < 20)
                return Q017.ONENESS[i];
            else if (20 <= i && i < 100)
                return Q017.TENS[i / 10] + (i % 10 != 0 ? Q017.ONENESS[i % 10] : "");
            else if (100 <= i && i < 1000)
                return Q017.ONENESS[i / 100] + "hundred" + (i % 100 != 0 ? "and" + ConvertNumberToEnglishUK(i % 100) : "");
            else if (1000 <= i && i < 1000000)
                return ConvertNumberToEnglishUK(i / 1000) + "thousand" + (i % 1000 != 0 ? ConvertNumberToEnglishUK(i % 1000) : "");
            else
                throw new Exception();
        }
    }
}
