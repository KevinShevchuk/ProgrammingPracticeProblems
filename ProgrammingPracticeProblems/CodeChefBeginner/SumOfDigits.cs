using System;

//You're given an integer N. Write a program to calculate the sum of all the digits of N.

//Input
//The first line contains an integer T, total number of testcases.Then follow T lines, each line contains an integer N.

//Output
//Calculate the sum of digits of N.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ N ≤ 1000000

//Example

//Input
//3 
//12345
//31203
//2123

//Output
//15
//9
//8

namespace PracticeProblems
{
    class SumOfDigits
    {
        public SumOfDigits()
        {
            Console.WriteLine("Input the number of items followed by each item in the list to sort:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[] tests = new int[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                int.TryParse(Console.ReadLine(), out tests[i]);
            }

            foreach(int t in tests)
            {
                Console.WriteLine(SumDigits(t));
            }
        }

        private int SumDigits(int input)
        {
            int sum = 0;
            while (input > 0)
            {
                int rem = input % 10;
                sum += rem;
                input = input / 10;
            }
            return sum;
        }
    }
}
