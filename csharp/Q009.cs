using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// a^2 + b^2 = c^2
    /// For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    /// Find the product abc.
    /// </summary>
    public class Q009 : IEulerProblem
    {
        private int PERIMETER = 1000;

        public string Solve()
        {
            for (int a = 1; a < PERIMETER; a++)
            {
                for (int b = a + 1; b < PERIMETER; b++)
                {
                    int c = PERIMETER - a - b;
                    if (a * a + b * b == c * c)
                    {
                        // It is now implied that b < c, because we have a > 0
                        return (a * b * c).ToString();
                    }
                }
            }
            throw new Exception("Not found");
        }
    }
}
