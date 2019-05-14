using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LeadGame
    {
        public LeadGame()
        {
            Console.WriteLine("Input the number of followed by the scores for each round:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[,] inputTests = new int[numberOfTests, 2];
            int p1 = 0;
            int p2 = 0;

            string tempInput;
            for (int i = 0; i < numberOfTests; i++)
            {
                tempInput = Console.ReadLine();
                string[] tempSplitInput = tempInput.Split(' ');
                int.TryParse(tempSplitInput[0], out inputTests[i, 0]);
                int.TryParse(tempSplitInput[1], out inputTests[i, 1]);
                if(inputTests[i, 0] > inputTests[i, 1])
                {
                    p1 += inputTests[i, 0] - inputTests[i, 1];
                }
                else
                {
                    p2 += inputTests[i, 1] - inputTests[i, 0];
                }
            }
            if(p1 > p2)
            {
                Console.WriteLine(1 + " " + p1);
            }
            else
            {
                Console.WriteLine(2 + " " + p2);
            }
        }
    }
}
