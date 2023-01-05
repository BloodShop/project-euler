using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,

    ///The square of the sum of the first ten natural numbers is,
    ///
    ///Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
    ///
    ///Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    public class Q006 : IEulerProblem
    {
        public string Solve()
        {
            int num = 100;
            double square = SquareOfNums(num);
            double sum = SumOfSquareNums(num);
            return (sum - square).ToString();
        }

        double SquareOfNums(int num)
        {
            double sum = 0;
            for (int i = 1; i <= num; i++)
                sum += Math.Pow(i, 2);
            return sum;
        }
        double SumOfSquareNums(int num)
        {
            double sum = 0;
            for (int i = 1; i <= num; i++)
                sum += i;
            sum = Math.Pow(sum, 2);
            return sum;
        }
    }
}
