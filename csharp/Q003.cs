namespace csharp
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    public class Q003 : IEulerProblem
    {
        public string Solve()
        {
            long num = 600851475143;
            int sqrtNum = (int)Math.Sqrt(num);
            for (int i = sqrtNum; i >= 2; i--)
                if (num % i == 0)
                    if (isPrime(i))
                        return i.ToString();
            return "-1";
        }

        private bool isPrime(long num)
        {
            if (num == 2)
                return true;
            int sqrtNum = (int)Math.Sqrt(num);
            for (int i = sqrtNum; i >= 2; i--)
                if (num % i == 0)
                    return false;
            return true;
        }
    }
}
