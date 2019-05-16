using System;

//You are asked to calculate factorials of some small positive integers.

//Input
//An integer t, 1<=t<=100, denoting the number of testcases, followed by t lines, each containing a single integer n, 1<=n<=100.

//Output
//For each integer n given at input, display a line with the value of n!

//Example
//Sample input:
//4
//1
//2
//5
//3
//Sample output:

//1
//2
//120
//6

namespace PracticeProblems
{
    class SmallFactorial
    {
        public SmallFactorial()
        {
            Console.WriteLine("Input the number of tests followed by the number to find the factorial of:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                Solution1(numberOfTests);
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public void Solution1(int numberOfTests)
        {
            int[] tests = new int[numberOfTests];
            int inputs = 0;
            while (inputs < numberOfTests)
            {
                bool success = int.TryParse(Console.ReadLine(), out int test);
                if (success && test >= 1 && test <= 100)
                {
                    tests[inputs] = test;
                    inputs++;
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }

            foreach (int j in tests)
            {
                int sum = 1;
                for (int i = j; i > 0; i--)
                {
                    sum *= i;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
