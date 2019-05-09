using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class EnormousInputTest
    {
        //The purpose of this problem is to verify whether the method you are using to read input data is sufficiently fast to handle problems branded with the enormous Input/Output warning.You are expected to be able to process at least 2.5MB of input data per second at runtime.

        //Input
        //The input begins with two positive integers n k (n, k<=10^7). The next n lines of input contain one positive integer ti, not greater than 109, each.

        //Output
        //Write a single integer to output, denoting how many integers ti are divisible by k.

        //Example
        //Input:
        //7 3
        //1
        //51
        //966369
        //7
        //9
        //999996
        //11

        //Output:
        //4

        public EnormousInputTest()
        {
            Console.WriteLine("Input the number of tests followed by the number to test divisibility on:");
            string input = Console.ReadLine();
            Console.WriteLine(Solution1(input));
        }

        public int Solution1(string input)
        {
            string[] splitInput = input.Split(' ');
            int numberOfTests = 0;
            int.TryParse(splitInput[0], out numberOfTests);

            float divisor = 0;
            float.TryParse(splitInput[1], out divisor);

            int[] tests = new int[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                 int.TryParse(Console.ReadLine(), out tests[i]);
            }

            int passes = 0;
            foreach (int i in tests)
            {
                if (i % divisor == 0)
                {
                    passes++;
                }
            }
            return passes;
        }
    }
}
