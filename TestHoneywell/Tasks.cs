using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHoneywell
{
    public static class Tasks
    {

        public static int CountDuplicates(IList<int> numbers)
        {
            var originalLength = numbers.Count;
            var asSet = new HashSet<int>(numbers);

            return originalLength - asSet.Count;
        }

        public static void TwoThrees()
        {
            for (int i = 1; i <= 100; i++)
            {
                string currentOutput;
                if (i % 2 == 0)
                {
                    currentOutput = "two";

                    if (i % 3 == 0)
                    {
                        currentOutput += "three";
                    }
                }
                else if (i % 3 == 0)
                {
                    currentOutput = "three";
                }
                else
                {
                    currentOutput = i.ToString();
                }

                Console.WriteLine(currentOutput);
            }
        }
    }
}
