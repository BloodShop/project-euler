using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    /// 
    /// Find the sum of all the primes below two million.
    /// </summary>
    public class Q010 : IEulerProblem
    {
        public string Solve()
        {
            long num = 2000000;
            List<long> list = new List<long>();
            long sum = 0;
            while (num > 2)
            {
                num--;
                if (isPrime(num))
                    list.Add(num);
            }
            foreach (var i in list) // O(1)
                sum += i;
            return sum.ToString();
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
