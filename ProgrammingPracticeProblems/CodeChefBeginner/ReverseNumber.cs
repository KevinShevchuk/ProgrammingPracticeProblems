using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//If an Integer N, write a program to reverse the given number.

//Input
//The first line contains an integer T, total number of testcases.Then follow T lines, each line contains an integer N.

//Output
//Display the reverse of the given number N.

//Constraints
//1 ≤ T ≤ 1000
//1 ≤ N ≤ 100000

//Example
//Input
//4
//12345
//31203
//2123
//2300

//Output
//54321
//30213
//3212
//32

namespace PracticeProblems
{
    class ReverseNumber
    {
        public ReverseNumber()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 105)
            {
                int[] results = new int[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the number to reverse:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test <= int.MaxValue)
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
            int result = 0;
            while (input > 0)
            {
                int rem = input % 10;
                result = (result * 10) + rem;
                input = input / 10;
            }
            return result;
        }
    }
}
