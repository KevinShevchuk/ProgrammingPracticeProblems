using System;
using System.Linq;

//Kattapa, as you all know was one of the greatest warriors of his time.The kingdom of Maahishmati had never lost a battle under him (as army-chief), and the reason for that was their really powerful army, also called as Mahasena.
//Kattapa was known to be a very superstitious person.He believed that a soldier is "lucky" if the soldier is holding an even number of weapons, and "unlucky" otherwise.He considered the army as "READY FOR BATTLE" if the count of "lucky" soldiers is strictly greater than the count of "unlucky" soldiers, and "NOT READY" otherwise.
//Given the number of weapons each soldier is holding, your task is to determine whether the army formed by all these soldiers is "READY FOR BATTLE" or "NOT READY".
//Note: You can find the definition of an even number here.
//Input
//The first line of input consists of a single integer N denoting the number of soldiers. The second line of input consists of N space separated integers A1, A2, ..., AN, where Ai denotes the number of weapons that the ith soldier is holding.

//Output
//Generate one line output saying "READY FOR BATTLE", if the army satisfies the conditions that Kattapa requires or "NOT READY" otherwise (quotes for clarity).

//Constraints
//1 ≤ N ≤ 100
//1 ≤ Ai ≤ 100

//Example 1
//Input:
//1
//1

//Output:
//NOT READY
//Example 2
//Input:
//1
//2

//Output:
//READY FOR BATTLE
//Example 3
//Input:
//4
//11 12 13 14

//Output:
//NOT READY
//Example 4
//Input:
//3
//2 3 4

//Output:
//READY FOR BATTLE
//Example 5
//Input:
//5
//1 2 3 4 5

//Output:
//NOT READY

namespace PracticeProblems
{
    class Mahasena
    {
        public Mahasena()
        {
            Console.WriteLine("Input the size of the army:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                int[] results = new int[numberOfTests];
                Console.WriteLine("Enter the number of weapons each soldier is carrying:");
                string tempInput = Console.ReadLine();
                string[] tempSplitInput = tempInput.Split(' ');
                if (tempSplitInput.Count() == numberOfTests)
                {
                    for(int i = 0; i < tempSplitInput.Count(); i++)
                    {
                        bool success1 = int.TryParse(tempSplitInput[i], out int input1);
                        if (success1 && input1 >= 1 && input1 <= 100)
                        {
                            results[i] = input1;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                            break;
                        }
                    }
                    Console.WriteLine(Solution1(numberOfTests, results));
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

        private string Solution1(int size, int[] army)
        {
            int even = 0;
            foreach (int s in army)
            {
                if (s % 2 == 0)
                    even++;
            }
            if (even > size / 2)
                return "READY FOR BATTLE";
            else
                return "NOT READY";
        }
    }
}
