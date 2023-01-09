using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Net.NetworkInformation;
using System;
using System.Numerics;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace csharp
{
    /// <summary>
    /// Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names,
    /// begin by sorting it into alphabetical order.Then working out the alphabetical value for each name,
    /// multiply this value by its alphabetical position in the list to obtain a name score.
    /// For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
    /// So, COLIN would obtain a score of 938 × 53 = 49714.
    ///
    /// What is the total of all the name scores in the file?
    /// </summary>
    public class Q022 : IEulerProblem
    {
        public string Solve()
        {
            var workingDirectory = Environment.CurrentDirectory;
            var basePath = Directory.GetParent(workingDirectory)?.Parent?.Parent?.FullName + "\\Q022.txt";
            using (var sr = new StreamReader(basePath))
            {
                int total = 0, counter = 1;
                string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                string[] str = sr.ReadToEnd().Replace("\"", "").Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                Array.Sort(str);

                foreach (var s in str)
                {
                    int sum = 0;
                    foreach (var c in s)
                        sum += alpha.IndexOf(c) + 1;
                    
                    total += sum * counter;
                    counter++;
                }
                return total.ToString();
            }
        }
    }
}
