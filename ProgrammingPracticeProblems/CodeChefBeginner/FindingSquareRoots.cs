using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//In olden days finding square roots seemed to be difficult but nowadays it can be easily done using in-built functions available across many languages.

//Assume that you happen to hear the above words and you want to give a try in finding the square root of any given integer using in-built functions.So here's your chance.

//Input
//The first line of the input contains an integer T, the number of test cases.T lines follow.Each T contains an integer N whose square root needs to be computed.

//Output
//For each line of input output the square root of the input integer.

//Constraints
//1<=T<=20 
//1<=N<=10000

//Input:
//3
//10
//5
//10000

//Output:
//3
//2
//100

namespace PracticeProblems
{
    class FindingSquareRoots
    {
        public FindingSquareRoots()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 20)
            {
                double[] results = new double[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the number to find the square root of:");
                    bool success1 = double.TryParse(Console.ReadLine(), out double test);
                    if (success1 && test <= Math.Pow(10, 4))
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

        public double Solution1(double input)
        {
            return Math.Sqrt(input);
        }
    }
}
