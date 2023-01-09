using System.Numerics;

namespace csharp
{
    /// <summary>
    /// n! means n × (n − 1) × ... × 3 × 2 × 1
    ///
    /// For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
    /// and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
    /// 
    /// Find the sum of the digits in the number 100!
    /// </summary>
    public class Q019 : IEulerProblem
    {
        public string Solve()
        {
            int num = 100, total = 0;
            BigInteger res = BigInteger.One;

            for (int i = num; i > 1; i--)
                res *= i;

            foreach (var c in res.ToString())
                total += int.Parse(c.ToString());
            
            return total.ToString();
        }
        
    }
}
