using System;
using System.Linq;

//Write a program to check whether a triangle is valid or not, when the three angles of the triangle are the inputs.A triangle is valid if the sum of all the three angles is equal to 180 degrees.

//Input
//The first line contains an integer T, total number of testcases. Then follow T lines, each line contains three angles A, B and C of triangle separated by space.

//Output
//Display 'YES' or 'NO' if the triangle is Valid or not respectively.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ A, B, C ≤ 180

//Example
//Input
//3 
//40 40 100
//45 45 90
//180 1 1

//Output
//YES
//YES
//NO

namespace PracticeProblems
{
    class ValidTriangles
    {
        public ValidTriangles()
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
                    Console.WriteLine("Enter the angles of each vertex:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    if (tempSplitInput.Count() == 3)
                    {
                        bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                        bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                        bool success3 = int.TryParse(tempSplitInput[2], out int input3);
                        if (success1 && success2 && success3 && input1 >= 1 && input1 <= 180 && input2 >= 1 && input2 <= 180 && input3 >= 1 && input3 <= 180)
                        {
                            results[inputs] = Solution1(input1, input2, input3);
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

        public string Solution1(int input1, int input2, int input3)
        {
            return input1 + input2 + input3 == 180 ? "YES" : "NO";
        }
    }
}
