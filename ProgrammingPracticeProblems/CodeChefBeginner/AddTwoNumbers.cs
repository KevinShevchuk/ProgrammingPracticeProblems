using System;
using System.Linq;

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

namespace PracticeProblems
{
    class AddTwoNumbers
    {
        public AddTwoNumbers()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success)
            {
                Solution1(numberOfTests);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public void Solution1(int numberOfTests)
        {
            int[] results = new int[numberOfTests];

            string tempInput;
            int inputs = 0;
            while (inputs < numberOfTests)
            {
                Console.WriteLine("Enter a pair of numbers to sum together:");
                tempInput = Console.ReadLine();
                string[] tempSplitInput = tempInput.Split(' ');
                if (tempSplitInput.Count() == 2)
                {
                    bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                    bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                    if (success1 && success2 && input1 >= 1 && input1 <= 10000 && input2 >= 1 && input2 <= 10000)
                    {
                        results[inputs] = input1 + input2;
                        inputs++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            foreach (int i in results)
            {
                Console.WriteLine(i);
            }
        }
    }
}
