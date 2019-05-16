using System;
using System.Linq;

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

namespace PracticeProblems
{
    class EnormousInputTest
    {
        public EnormousInputTest()
        {
            Console.WriteLine("Input the number of tests followed by the number to test divisibility on:");
            string input = Console.ReadLine();

            string[] splitInput = input.Split(' ');
            if (splitInput.Count() == 2)
            {
                int.TryParse(splitInput[0], out int numberOfTests);
                float.TryParse(splitInput[1], out float divisor);
                if (numberOfTests > 0 && divisor > 0 && divisor <= Math.Pow(10, 7))
                {
                    int[] tests = new int[numberOfTests];
                    int inputs = 0;
                    while (inputs < numberOfTests)
                    {
                        Console.WriteLine("Enter a number to test divisbility on:");
                        bool success = int.TryParse(Console.ReadLine(), out int test);
                        if (success && test <= Math.Pow(10, 9))
                        {
                            tests[inputs] = test;
                            inputs++;
                        }
                        else
                        {
                            Console.WriteLine("Input too large.");
                        }
                    }
                    Console.WriteLine(Solution1(tests, divisor));
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public int Solution1(int[] tests, float divisor)
        {
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
