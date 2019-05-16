using System;

//Given the list of numbers, you are to sort them in non decreasing order.
//Input
//t – the number of numbers in list, then t lines follow[t <= 10 ^ 6]. 
//Each line contains one integer: N[0 <= N <= 10 ^ 6]

//Output
//Output given numbers in non decreasing order.

//Example

//Input:
//5
//5
//3
//6
//7
//1

//Output:
//1
//3
//5
//6
//7

namespace PracticeProblems
{
    class TurboSort
    {
        public TurboSort()
        {
            Console.WriteLine("Input the number of items followed by each item in the list to sort:");
            string input = Console.ReadLine();
            Solution1(input);
        }

        public void Solution1(string input)
        {
            int numberOfTests = 0;
            int.TryParse(input, out numberOfTests);

            int[] tests = new int[numberOfTests];
            for (int i = 0; i < numberOfTests; i++)
            {
                int.TryParse(Console.ReadLine(), out tests[i]);
            }

            int j = 1;
            while (j < tests.Length)
            {
                int k = j;
                while (k > 0 && tests[k - 1] > tests[k])
                {
                    int swap = tests[k - 1];
                    tests[k - 1] = tests[k];
                    tests[k] = swap;
                    k--;
                }
                j++;
            }

            foreach (int t in tests)
            {
                Console.WriteLine(t);
            }
        }
    }
}
