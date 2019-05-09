using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    //The sum of the squares of the first ten natural numbers is,
    //1^2 + 2^2 + ... + 10^2 = 385
    //The square of the sum of the first ten natural numbers is,
    //(1 + 2 + ... + 10)^2 = 552 = 3025
    //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

    class SumSquareDifference
    {
        public SumSquareDifference()
        {
            Console.WriteLine("Input the number to find the sum square difference of:");
            string input = Console.ReadLine();
            int max = 0;
            if (int.TryParse(input, out max))
            {
                Console.WriteLine("----------Solution 1:-----------");
                Console.WriteLine(Solution1(max));
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        private int Solution1(int max)//O(n)
        {
            int sum = 0; 
            int squ = 0;
            for (int i = 1; i <= max; i++)
            {
                sum += i;
                squ += (i * i);
            }
            sum *= sum;
            return sum - squ;
        }
    }
}
