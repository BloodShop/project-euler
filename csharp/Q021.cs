using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace csharp
{
    /// <summary>
    /// Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
    /// If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
    /// 
    /// For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284.
    /// The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
    /// Evaluate the sum of all the amicable numbers under 10000.
    /// </summary>
    public class Q021 : IEulerProblem
    {
        public string Solve()
        {
            List<int> list = new List<int>();
            int[] ints = new int[10000];
            for (int i = 7; i < 10000; i++)
            {
                int sum1 = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0) sum1 += j;
                }
                int sum2 = 0;
                for (int k = 1; k < sum1; k++)
                {
                    if (sum1 % k == 0) sum2 += k;
                }
                if (sum2 == i && sum1 != i)
                {
                    if (!list.Contains(sum2))
                        list.Add(sum2);
                    if (!list.Contains(sum1))
                        list.Add(sum1);
                }
                else
                    ints[i] = i;
            }
            return list.Sum().ToString();
        }
        
    }
}
