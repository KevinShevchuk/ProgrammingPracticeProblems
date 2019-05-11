using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SumOfDigits
    {
        public SumOfDigits()
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

            foreach(int t in tests)
            {
                Console.WriteLine(SumDigits(t));
            }
        }

        private int SumDigits(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int rem = input % 10;
                sum += rem;
                input = input / 10;
            }
            return sum;
        }
    }
}
