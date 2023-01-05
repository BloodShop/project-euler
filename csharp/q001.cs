using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class q001 : IEulerProblem
    {
        public string Solve()
        {
            int sum = 0;
            for (int i = 3; i < 1000; i++)
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            return sum.ToString();
        }
    }
}
