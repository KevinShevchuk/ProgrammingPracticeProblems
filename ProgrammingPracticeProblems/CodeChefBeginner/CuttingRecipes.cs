using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The chef has a recipe he wishes to use for his guests, but the recipe will make far more food than he can serve to the guests.The chef therefore would like to make a reduced version of the recipe which has the same ratios of ingredients, but makes less food. The chef, however, does not like fractions. The original recipe contains only whole numbers of ingredients, and the chef wants the reduced recipe to only contain whole numbers of ingredients as well.Help the chef determine how much of each ingredient to use in order to make as little food as possible.

//Input
//Input will begin with an integer T, the number of test cases.Each test case consists of a single line.The line begins with a positive integer N, the number of ingredients. N integers follow, each indicating the quantity of a particular ingredient that is used.

//Output
//For each test case, output exactly N space-separated integers on a line, giving the quantity of each ingredient that the chef should use in order to make as little food as possible.

//Sample Input
//3
//2 4 4
//3 2 3 4
//4 3 15 9 6

//Sample Output
//1 1
//2 3 4
//1 5 3 2

//Constraints
//T≤100
//2≤N≤50
//All ingredient quantities are between 1 and 1000, inclusive.

namespace PracticeProblems.CodeChefBeginner
{
    class CuttingRecipes
    {
        private static readonly IEnumerable<int> _primes = new HashSet<int> { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241, 251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593, 599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659, 661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743, 751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827, 829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911, 919, 929, 937, 941, 947, 953, 967, 971, 977, 983, 991, 997 };

        public CuttingRecipes()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                List<int[]> inputs = new List<int[]>();
                int tests = 0;
                while (tests < numberOfTests)
                {
                    Console.WriteLine("Enter the number of ingredients followed by the amount of each ingredient:");
                    string tempInput = Console.ReadLine();
                    string[] tempSplitInput = tempInput.Split(' ');
                    int[] tempIntInput = new int[tempSplitInput.Count() - 1];
                    bool success1 = int.TryParse(input, out int numInEntry);
                    if (success1 && numInEntry == tempSplitInput.Count() - 2 && numInEntry >= 2 && numInEntry <= 50)
                    {
                        for (int i = 1; i < tempSplitInput.Count() - 1; i++)
                        {
                            bool success2 = int.TryParse(tempSplitInput[i], out int quant);
                            if (success2 && quant >= 1 && quant <= 1000)
                            {
                                tempIntInput[i - 1] = quant;
                            }
                            else
                            {
                                Console.WriteLine("Input too large.");
                            }
                        }
                        inputs.Add(tempIntInput);
                    }
                    tests++;
                }

                List<int[]> results = new List<int[]>();

                foreach(int[] k in inputs)
                {
                    results.Add(Solution1(k));
                }

                foreach (int[] l in results)
                {
                    Console.WriteLine(l);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        private int[] Solution1(int[] input)
        {
            int[] results = new int[input.Count() - 1];
            float[] temp = new float[input.Count() - 1];

            //If any of the input numbers is prime return the list.
            foreach (int i in input)
            {
                if (_primes.Contains(i))
                    return input;
            }

            //Find the smallest number in the input
            int smallest = int.MaxValue;
            foreach (int j in input)
            {
                if (j < smallest)
                    smallest = j;
            }

            //Find the divisors of the smallest value.
            List<int> divisors = new List<int>();
            int divisor = 2;
            while (divisor <= smallest / 2)
            {
                if (smallest % divisor == 0)
                {
                    divisors.Add(divisor);
                }
                divisor++;
            }

            //Test dividing the remaining values by each of the divisors.
            foreach (int k in divisors)
            {
                bool even = true;
                foreach (int l in input)
                {
                    if(l % k != 0)
                    {
                        even = false;
                        break;
                    }
                }
                if (even)
                {
                    for (int i = 0; i < input.Count(); i++)
                    {
                        results[i] = input[i] % k;
                    }
                }
            }
            return results;
        }
    }
}
