using System;
using System.Linq;

//Let's consider a triangle of numbers in which a number appears in the first line, two numbers appear in the second line, three in the third line, etc. Develop a program which will compute the largest of the sums of numbers that appear on the paths starting from the top towards the base, so that:

//on each path the next number is located on the row below, more precisely either directly below or below and one place to the right;
//the number of rows is strictly positive, but less than 100
//all numbers are positive integers between 0 and 99.
//Input
//In the first line integer n - the number of test cases(equal to about 1000). Then n test cases follow.Each test case starts with the number of lines which is followed by their content.

//Output
//For each test case write the determined value in a separate line.

//Example
//Input:
//2
//3
//1
//2 1
//1 2 3
//4 
//1 
//1 2 
//4 1 2
//2 3 1 1 


//Output:
//5
//9

namespace PracticeProblems
{
    class SumsInATriangle
    {
        public SumsInATriangle()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 1000)
            {
                int[] results = new int[numberOfTests];

                int testNumber = 1;
                while (testNumber <= numberOfTests)
                {
                    Console.WriteLine("Input the size of the triangle:");
                    string sizeInput = Console.ReadLine();
                    bool success1 = int.TryParse(sizeInput, out int triangleSize);
                    if (success1 && triangleSize >= 1 && triangleSize < 100)
                    {
                        int[,] triangle = new int[triangleSize, triangleSize];

                        int rowMax = 1;
                        while (rowMax <= triangleSize)
                        {
                            Console.WriteLine("Enter the numbers in this row:");
                            string tempInput = Console.ReadLine();
                            string[] tempSplitInput = tempInput.Split(' ');
                            if (tempSplitInput.Count() == rowMax)
                            {
                                bool success2 = false;
                                int i = 0;
                                while (i < rowMax && rowMax <= triangleSize)
                                {
                                    success2 = int.TryParse(tempSplitInput[i], out int input1);
                                    if (success1 && input1 >= 0 && input1 < 100)
                                    {
                                        triangle[rowMax - 1, i] = input1;
                                        i++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Input.");
                                        success2 = false;
                                        break;
                                    }
                                }
                                if (success2)
                                {
                                    rowMax++;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input.");
                            }
                        }
                        results[testNumber - 1] = Solution1(triangle, triangleSize);
                        testNumber++;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public int Solution1(int[,] triangle, int triangleSize)
        {
            int result = 0;
            int rowMax = 1;
            int[,] sumTriangle = new int[triangleSize, triangleSize];

            for (int i = 0; i < triangleSize; i++)
            {
                for (int j = 0; j < rowMax; j++)
                {
                    if (i == 0 && j == 0)
                    {
                        sumTriangle[i, j] = triangle[i, j];
                    }
                    else
                    {
                        int temp1 = 0;
                        int temp2 = 0;
                        if (j < rowMax - 1)
                        {
                            temp1 = sumTriangle[i - 1, j] + triangle[i, j];
                        }
                        if (j > 0)
                        {
                            temp2 = sumTriangle[i - 1, j - 1] + triangle[i, j];
                        }
                        if (temp1 > temp2)
                        {
                            sumTriangle[i, j] = temp1;
                        }
                        else
                        {
                            sumTriangle[i, j] = temp2;
                        }
                    }
                }
                rowMax++;
            }

            for (int k = 0; k < triangleSize; k++)
            {
                if (result < sumTriangle[triangleSize - 1, k])
                {
                    result = sumTriangle[triangleSize - 1, k];
                }
            }
            return result; 
        }
    }
}
