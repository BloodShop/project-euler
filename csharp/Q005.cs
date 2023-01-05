using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    public class Q005 : IEulerProblem
    {
        public string Solve()
        {
            int strNumber = 1, fnshNumber = 20;
            ArrayList myValues = new ArrayList();
            long num;
            int[] arr = new int[100];
            int numOfIterations = 0, k = 0;
            for (int i = strNumber; i <= fnshNumber; i++) // 1 - 20
            {
                if (isPrime(i))
                {
                    arr[k] = i;
                    k++;
                }
                else
                {
                    int lastStop = 0;                         // arr -> { 1, 2, 3, }
                    myValues = GetTheSmallestMultiplyNums(i); // 4 --> 2 2
                    foreach (int val in myValues)
                        for (int j = lastStop; j < k; j++)
                            if (arr[j] == val)
                            {
                                lastStop = j + 1;
                                break;
                            }
                            else if (j == k - 1)
                            {
                                arr[k] = val;
                                k++;
                            }
                }

                numOfIterations = k;

            }
            // prints the array
            foreach (int op in arr)
                if (op != 0)
                    Console.Write(op + "\t");
            Console.WriteLine("\n");

            // sums all the numbers needed
            num = 1;
            for (int i = 0; i < k; i++)
                if (arr[i] != 0)
                    num *= arr[i];

            return num.ToString();
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

        private ArrayList GetTheSmallestMultiplyNums(int num)
        {
            int tempNum = num;
            ArrayList arrayList = new ArrayList();

            if (isPrime(num))
            {
                arrayList.Add(num);
                return arrayList;
            }
            for (int i = 2; i < num; i++)
                if (tempNum % i == 0)
                {
                    for (int j = i; j < tempNum; j++)
                        while (tempNum % j == 0)
                        {
                            tempNum /= j; // 21 7
                            arrayList.Add(j); // 2 // 3
                        }
                    if (tempNum != 1)
                        arrayList.Add(tempNum);
                    break;
                }

            return arrayList;
        }
    }
}
