using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
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
