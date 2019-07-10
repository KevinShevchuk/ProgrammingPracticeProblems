using System;

namespace PracticeProblems
{
    public class TotalExpenses
    {
        public TotalExpenses()
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
                    Console.WriteLine("Enter the quantity and price:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    if (tempSplitInput.Count() == 2)
                    {
                        bool success1 = int.TryParse(tempSplitInput[0], out int input1);
                        bool success2 = int.TryParse(tempSplitInput[1], out int input2);
                        if (success1 && success2 && input1 >= 1 && input1 <= 100000 && input2 >= 1 && input2 <= 100000)
                        {
                            results[inputs] = Solution1(input1, input2);
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
                    Console.WriteLine(results[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public int Solution1(int quantity, int price)
        {
            return quantity > 1000 ? quantity * price : (quantity * price) * .9;
        }
    }
}
