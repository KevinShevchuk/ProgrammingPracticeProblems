using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    //Shivam is the youngest programmer in the world, he is just 12 years old.Shivam is learning programming and today he is writing his first program. 

    //Program is very simple, Given two integers A and B, write a program to add these two numbers.

    //Input
    //The first line contains an integer T, total number of test cases.Then follow T lines, each line contains two Integers A and B.

    //Output
    //Add A and B and display it.

    //Constraints
    //1 ≤ T ≤ 1000
    //1 ≤ A, B ≤ 10000
    //Example
    //Input
    //3 
    //1 2
    //100 200
    //10 40

    //Output
    //3
    //300
    //50

    class AddTwoNumbers
    {
        public AddTwoNumbers()
        {
            Console.WriteLine("Input the number of tests followed by pairs of numbers to sum together:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[,] inputTests = new int[numberOfTests,2];
            int[] results = new int[numberOfTests];

            string tempInput;
            for (int i = 0; i < numberOfTests; i++)
            {
                tempInput = Console.ReadLine();
                string[] tempSplitInput = tempInput.Split(' ');
                int.TryParse(tempSplitInput[0], out inputTests[i, 0]);
                int.TryParse(tempSplitInput[1], out inputTests[i, 1]);
                results[i] = inputTests[i, 0] + inputTests[i, 1];
            }
            foreach (int i in results)
            {
                Console.WriteLine(i);
            }
        }
    }
}
