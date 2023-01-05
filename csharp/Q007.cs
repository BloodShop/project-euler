using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    ///
    /// What is the 10001st prime number?
    /// </summary>
    public class Q007 : IEulerProblem
    {
        public string Solve()
        {
            int numOfIndexes = 10001;
            int[] array = new int[numOfIndexes];
            for (int i = 2, j = 0; i < int.MaxValue && j < numOfIndexes; i++)
                if (isPrime(i))
                {
                    array[j] = i;
                    j++;
                }

            return array[10000].ToString();
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
