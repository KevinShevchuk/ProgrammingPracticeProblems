using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Consider a currency system in which there are notes of seven denominations, namely, Rs. 1, Rs. 2, Rs. 5, Rs. 10, Rs. 50, Rs. 100.
//If the sum of Rs.N is input, write a program to computer smallest number of notes that will combine to give Rs.N.

//Input
//The first line contains an integer T, total number of testcases.Then follow T lines, each line contains an integer N.

//Output
//Display the smallest number of notes that will combine to give N.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ N ≤ 1000000

//Example
//Input
//3 
//1200
//500
//242

//Output
//12
//5
//7

namespace PracticeProblems
{
    class SmallestNumberOfNotes
    {
        private readonly int[] values = new int[] { 100, 50, 20, 10, 5, 2, 1 };

        public SmallestNumberOfNotes()
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
                    Console.WriteLine("Enter the total value of the bills:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test <= Math.Pow(10, 8))
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

        public int Solution1(int test)
        {
            int count = 0;
            int index = 0;
            while (test > 0)
            {
                if (test - values[index] >= 0)
                {
                    test -= values[index];
                    count++;
                }
                else
                {
                    index++;
                }
            }
            return count;
        }
    }
}
