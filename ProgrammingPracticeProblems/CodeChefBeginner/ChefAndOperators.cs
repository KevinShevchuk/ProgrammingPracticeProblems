using System;
using System.Linq;

//Chef has just started Programming, he is in first year of Engineering.Chef is reading about Relational Operators. 
//Relational Operators are operators which check relatioship between two values. Given two numerical values A and B you need to help chef in finding the relationship between them that is,
//First one is greater than second or,
//First one is less than second or,
//First and second one are equal.

//Input
//First line contains an integer T, which denotes the number of testcases. Each of the T lines contain two integers A and B.

//Output
//For each line of input produce one line of output.This line contains any one of the relational operators
//'≺' , '≻' , '='.

//Constraints
//1 ≤ T ≤ 10000
//1 ≤ A, B ≤ 1000000001

//Example
//Input:
//3
//10 20
//20 10
//10 10

//Output:
//≺
//≻
//=

namespace PracticeProblems
{
    class ChefAndOperators
    {
        public ChefAndOperators()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 10000)
            {
                string[] results = new string[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the two numbers to compare:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    if (tempSplitInput.Count() == 2)
                    {
                        bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                        bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                        if (success1 && success2 && input1 >= 0 && input1 <= 1000000001 && input2 >= 0 && input2 <= 1000000001)
                        {
                            results[inputs] = Solution1(input1, input2);
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
                for (int i = 0; i < results.GetLength(0); i++)
                {
                    Console.WriteLine(results[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public string Solution1(int input1, int input2)
        {
            if (input1 > input2)
            {
                return ">";
            }
            if (input1 < input2)
            {
                return "<";
            }
            return "=";
        }
    }
}
