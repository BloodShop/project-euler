using System.Numerics;

namespace csharp
{
    /// <summary>
    /// The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317.
    ///
    /// Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
    /// </summary>
    public class Q048 : IEulerProblem
    {
        public string Solve()
        {
            BigInteger modulus = (BigInteger)Math.Pow(10, 10), sum = BigInteger.Zero;
            for (int i = 1; i <= 1000; i++)
                sum += BigInteger.ModPow(i, (BigInteger)i, modulus);

            return (sum % modulus).ToString();
        }
    }
}
