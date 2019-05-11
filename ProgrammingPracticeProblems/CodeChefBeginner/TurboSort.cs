using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class TurboSort
    {
        public TurboSort()
        {
            Console.WriteLine("Input the number of items followed by each item in the list to sort:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[] tests = new int[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                int.TryParse(Console.ReadLine(), out tests[i]);
            }

            int j = 1;
            while (j < tests.Length)
            {
                int k = j;
                while (k > 0 && tests[k - 1] > tests[k])
                {
                    int swap = tests[k - 1];
                    tests[k - 1] = tests[k];
                    tests[k] = swap;
                    k--;
                }
                j++;
            }

            foreach (int t in tests)
            {
                Console.WriteLine(t);
            }
        }
    }
}
