using System;

//Give an integer N.Write a program to obtain the sum of the first and last digit of this number.

//Input
//The first line contains an integer T, total number of test cases.Then follow T lines, each line contains an integer N.

//Output
//Display the sum of first and last digit of N.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ N ≤ 1000000

//Example
//Input
//3 
//1234
//124894
//242323

//Output
//5
//5
//5

namespace PracticeProblems
{
    class FirstAndLastDigit
    {
        public FirstAndLastDigit()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 1000)
            {
                int[] results = new int[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the number to find the sum of the first and last digits of:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test <= Math.Pow(10, 6))
                    {
                        results[inputs] = Solution1(test);
                        inputs++;
                    }
                    else
                    {
                        Console.WriteLine("Input too large.");
                    }
                }
                foreach (int i in results)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public int Solution1(int input)
        {
            int sum = 0;
            bool first = true;
            while (input > 0)
            {
                int rem = input % 10;
                if (first | input < 10)
                {
                    sum += rem;
                    first = false;
                }
                input = input / 10;
            }
            return sum;
        }
    }
}
