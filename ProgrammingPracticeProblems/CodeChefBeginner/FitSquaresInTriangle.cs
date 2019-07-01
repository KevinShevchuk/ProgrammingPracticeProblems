using System;

//What is the maximum number of squares of size 2x2 that can be fit in a right angled isosceles triangle of base B.
//One side of the square must be parallel to the base of the isosceles triangle.
//Base is the shortest side of the triangle

//Input
//First line contains T, the number of test cases.
//Each of the following T lines contains 1 integer B.

//Output
//Output exactly T lines, each line containing the required answer. 

//Constraints
//1 ≤ T ≤ 103
//1 ≤ B ≤ 104

//Sample Input

//11
//1
//2
//3
//4
//5
//6
//7
//8
//9
//10
//11
//Sample Output 

//0
//0
//0
//1
//1
//3
//3
//6
//6
//10
//10

namespace PracticeProblems
{
    class FitSquaresInTriangle
    {
        public FitSquaresInTriangle()
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
                    Console.WriteLine("Enter the length of the base of the triangle:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test >= 1 && test <= 1000)
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

        private int Solution1(int input)
        {
            input = input - 2;
            input = input / 2;
            return input * (input + 1) / 2;
        }
    }
}
