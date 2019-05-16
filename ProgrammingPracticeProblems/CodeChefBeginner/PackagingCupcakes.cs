using System;

//Now that Chef has finished baking and frosting his cupcakes, it's time to package them. Chef has N cupcakes, and needs to decide how many cupcakes to place in each package. Each package must contain the same number of cupcakes. Chef will choose an integer A between 1 and N, inclusive, and place exactly A cupcakes into each package. Chef makes as many packages as possible. Chef then gets to eat the remaining cupcakes. Chef enjoys eating cupcakes very much. Help Chef choose the package size A that will let him eat as many cupcakes as possible.

//Input
//Input begins with an integer T, the number of test cases.Each test case consists of a single integer N, the number of cupcakes.

//Output
//For each test case, output the package size that will maximize the number of leftover cupcakes.If multiple package sizes will result in the same number of leftover cupcakes, print the largest such size.

//Constraints
//1 ≤ T ≤ 1000
//2 ≤ N ≤ 100000000 (10^8)

//Sample Input
//2
//2
//5

//Sample Output
//2
//3

//Explanation
//In the first test case, there will be no leftover cupcakes regardless of the size Chef chooses, so he chooses the largest possible size.In the second test case, there will be 2 leftover cupcakes.

namespace PracticeProblems
{
    class PackagingCupcakes
    {
        public PackagingCupcakes()
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
                    Console.WriteLine("Enter the number of cupcakes:");
                    bool success1 = int.TryParse(Console.ReadLine(), out int test);
                    if (success1 && test <= Math.Pow(10, 8))
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

        public int Solution1(int test)
        {
            if (test % 2 == 0)
            {
                return test / 2;
            }
            else
            {
                return (test / 2) + 1;
            }

        }
    }
}
