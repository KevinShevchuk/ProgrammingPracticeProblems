using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SmallFactorial
    {
        public SmallFactorial()
        {
            Console.WriteLine("Input the number of tests followed by the number to find the factorial of:");
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

            foreach (int j in tests)
            {
                int sum = 1;
                for (int i = j; i > 0; i--)
                {
                    sum *= i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
