using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Three numbers A, B and C are the inputs.Write a program to find second largest among three numbers.

//Input
//The first line contains an integer T, total number of testcases. Then follow T lines, each line contains three integers A, B and C.

//Output
//Display the second largest among A, B and C.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ A, B, C ≤ 1000000

//Example
//Input
//3 
//120 11 400
//10213 312 10
//10 3 450

//Output

//120
//312
//10

namespace PracticeProblems
{
    class SecondLargest
    {
        public SecondLargest()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                int[] results = new int[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the three numbers:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    if (tempSplitInput.Count() == 3)
                    {
                        bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                        bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                        bool success3 = int.TryParse(tempSplitInput[2], out int input3);
                        if (success1 && success2 && success3 && input1 >= 1 && input1 <= 1000000 && input2 >= 1 && input2 <= 1000000 && input3 >= 1 && input3 <= 1000000)
                        {
                            int[] numbers = new int[] { input1, input2, input3 };
                            results[inputs] = Solution1(numbers);
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

        public int Solution1(int[] numbers)
        {
            Array.Sort(numbers);
            return numbers[1];
        }
    }
}
