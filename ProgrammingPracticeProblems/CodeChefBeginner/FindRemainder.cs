using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class FindRemainder
    {
        public FindRemainder()
        {
            Console.WriteLine("Input the number of tests followed by pairs of numbers to find the remainder of:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[,] inputTests = new int[numberOfTests, 2];
            int[] results = new int[numberOfTests];

            string tempInput;
            for (int i = 0; i < numberOfTests; i++)
            {
                tempInput = Console.ReadLine();
                string[] tempSplitInput = tempInput.Split(' ');
                int.TryParse(tempSplitInput[0], out inputTests[i, 0]);
                int.TryParse(tempSplitInput[1], out inputTests[i, 1]);
                results[i] = inputTests[i, 0] % inputTests[i, 1];
            }
            foreach (int i in results)
            {
                Console.WriteLine(i);
            }
        }
    }
}
