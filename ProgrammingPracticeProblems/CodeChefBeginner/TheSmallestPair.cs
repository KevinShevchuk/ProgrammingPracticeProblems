using System;
using System.Collections.Generic;
using System.Linq;

//You are given a sequence a1, a2, ..., aN.Find the smallest possible value of ai + aj, where 1 ≤ i<j ≤ N.

//Input
//The first line of the input contains an integer T denoting the number of test cases.The description of T test cases follows.
//The first line of each description consists of a single integer N.
//The second line of each description contains N space separated integers - a1, a2, ..., aN respectively.

//Output
//For each test case, output a single line containing a single integer - the smallest possible sum for the corresponding test case.

//Constraints
//T = 105, N = 2 : 13 points.
//T = 105, 2 ≤ N ≤ 10 : 16 points.
//T = 1000, 2 ≤ N ≤ 100 : 31 points.
//T = 10, 2 ≤ N ≤ 105 : 40 points.
//1 ≤ ai ≤ 106

//Example
//Input:
//1
//4
//5 1 3 4

//Output:
//4

//Explanation
//Here we pick a2 and a3.Their sum equals to 1 + 3 = 4.

namespace PracticeProblems
{
	class TheSmallestPair
	{
        public TheSmallestPair()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                List<int[]> inputs = new List<int[]>();
                int tests = 0;
                while (tests < numberOfTests)
                {
                    Console.WriteLine("Enter the size of the list:");
                    string tempInput = Console.ReadLine();
                    bool success1 = int.TryParse(tempInput, out int listSize);

                    Console.WriteLine("Enter a space delimited list of numbers:");
                    string tempInput2 = Console.ReadLine();
                    string[] tempSplitInput = tempInput2.Split(' ');
                    int[] tempIntInput = new int[tempSplitInput.Count()];
                    if (success1 && listSize == tempSplitInput.Count())
                    {
                        for (int i = 0; i < tempSplitInput.Count(); i++)
                        {
                            bool success2 = int.TryParse(tempSplitInput[i], out int quant);
                            if (success2 && quant >= 1 && quant <= 1000000)
                            {
                                tempIntInput[i] = quant;
                            }
                            else
                            {
                                Console.WriteLine("Input too large.");
                            }
                        }
                        inputs.Add(tempIntInput);
                    }
                    tests++;
                }

                List<int> results = new List<int>();

                for(int k = 0; k < inputs.Count(); k++)
                {
                    results.Add(Solution1(inputs[k]));
                }

                foreach (int l in results)
                {
                    Console.WriteLine(l);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        private int Solution1(int[] inputList)
        {
            int smallest = int.MaxValue;
            for (int i = 0; i < inputList.Count() - 1; i++)
            {
                if (inputList[i] + inputList[i + 1] < smallest)
                {
                    smallest = inputList[i] + inputList[i + 1];
                }
            }
            return smallest;
        }
    }
}
