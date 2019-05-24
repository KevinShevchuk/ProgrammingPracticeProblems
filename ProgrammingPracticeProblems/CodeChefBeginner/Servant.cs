using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program, which takes an integer N and if the number is less than 10 then display "What an obedient servant you are!" otherwise print "-1".

//Input
//The first line contains an integer T, total number of testcases.Then follow T lines, each line contains an integer N.

//Output
//Output the given string or -1 depending on conditions.

//Constraints
//1 ≤ T ≤ 1000
//-20 ≤ N ≤ 20

//Example
//Input
//3 
//1
//12
//-5

//Output
//What an obedient servant you are!
//-1
//What an obedient servant you are!

namespace PracticeProblems
{
    class Servant
    {
        public Servant()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 1000)
            {
                string[] results = new string[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the number:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test >= -20 && test <= 20)
                    {
                        results[inputs] = Solution1(test);
                        inputs++;
                    }
                    else
                    {
                        Console.WriteLine("Input too large.");
                    }
                }
                foreach (string i in results)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public string Solution1(int input)
        {
            if (input < 10)
                return "What an obedient servant you are!";
            else
                return "-1";
        }
    }
}
