using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Chef is now a corporate person.He has to attend office regularly.But chef does not want to go to office, rather he wants to stay home and discover different recipes and cook them.

//In the office where chef works, has two guards who count how many times a person enters into the office building.Though the duty of a guard is 24 hour in a day, but sometimes they fall asleep during their duty and could not track the entry of a person in the office building.But one better thing is that they never fall asleep at the same time.At least one of them remains awake and counts who enters into the office.

//Now boss of Chef wants to calculate how many times Chef has entered into the building. He asked to the guard and they give him two integers A and B, count of first guard and second guard respectively.

//Help the boss to count the minimum and maximum number of times Chef could have entered into the office building.

//Input
//The first line of the input contains an integer T denoting the number of test cases.The description of the T test cases follows.

//Each test case consists of a line containing two space separated integers A and B.

//Output
//For each test case, output a single line containing two space separated integers, the minimum and maximum number of times Chef could have entered into the office building.

//Constraints
//1 ≤ T ≤ 100
//0 ≤ A, B ≤ 1000000
//Example
//Input:
//1
//19 17

//Output:
//19 36

namespace PracticeProblems
{
    class ChefAndRemissness
    {
        int[] _prices = new int[] { 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

        public ChefAndRemissness()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                int[,] results = new int[numberOfTests, 2];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the guards count:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    if (tempSplitInput.Count() == 2)
                    {
                        bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                        bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                        if (success1 && success2 && input1 >= 0 && input1 <= 1000000 && input2 >= 0 && input2 <= 1000000)
                        {
                            Solution1(ref input1, ref input2);
                            results[inputs, 0] = input1;
                            results[inputs, 1] = input2;
                            inputs++;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input.");
                    }
                }
                for (int i = 0; i < results.GetLength(0); i++)
                {
                    Console.WriteLine(results[i, 0] + " " + results[i, 1]);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public void Solution1(ref int input1, ref int input2)
        {
            int temp = input1 + input2;
            if (input1 >= input2)
            {
                input2 = temp;
            }
            else
            {
                input1 = input2;
                input2 = temp;
            }
        }
    }
}
