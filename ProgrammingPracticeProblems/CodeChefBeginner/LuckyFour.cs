using System;

//Kostya likes the number 4 much.Of course! This number has such a lot of properties, like:

//Four is the smallest composite number;
//It is also the smallest Smith number;
//The smallest non-cyclic group has four elements;
//Four is the maximal degree of the equation that can be solved in radicals;
//There is four-color theorem that states that any map can be colored in no more than four colors in such a way that no two adjacent regions are colored in the same color;
//Lagrange's four-square theorem states that every positive integer can be written as the sum of at most four square numbers;
//Four is the maximum number of dimensions of a real division algebra;
//In bases 6 and 12, 4 is a 1-automorphic number;
//And there are a lot more cool stuff about this number!
//Impressed by the power of this number, Kostya has begun to look for occurrences of four anywhere. He has a list of T integers, for each of them he wants to calculate the number of occurrences of the digit 4 in the decimal representation. He is too busy now, so please help him.

//Input
//The first line of input consists of a single integer T, denoting the number of integers in Kostya's list.

//Then, there are T lines, each of them contain a single integer from the list.

//Output
//Output T lines. Each of these lines should contain the number of occurences of the digit 4 in the respective integer from Kostya's list.

//Constraints
//1 ≤ T ≤ 105
//(Subtask 1): 0 ≤ Numbers from the list ≤ 9 - 33 points.
//(Subtask 2): 0 ≤ Numbers from the list ≤ 109 - 67 points.
//Example
//Input:
//5
//447474
//228
//6664
//40
//81

//Output:
//4
//0
//1
//1
//0

namespace PracticeProblems
{
    class LuckyFour
    {
        public LuckyFour()
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
                    Console.WriteLine("Enter the number to count the instances of the digit 4:");
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
            int count = 0;
            while (input > 0)
            {
                int rem = input % 10;
                if (rem == 4)
                {
                    count++;
                }
                input = input / 10;
            }
            return count;
        }
    }
}
