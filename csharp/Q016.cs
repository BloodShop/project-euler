using System;
using System.Numerics;

namespace csharp
{
    /// <summary>
    /// 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
    ///
    /// What is the sum of the digits of the number 2^1000?
    /// </summary>
    public class Q016 : IEulerProblem
    {
        public string Solve()
        {
            int num = 1000;
            BigInteger num1 = 1, res = 0;

            for (int i = 0; i < num; i++)
                num1 *= 2;

            while (num1 > 0)
            {
                res += num1 % 10;
                num1 /= 10;
            }

            return res.ToString();
        }
    }
}
