using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class MultiplesOf3And5
    {
        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
        //Find the sum of all the multiples of 3 or 5 below 1000.

        public MultiplesOf3And5()
        {
            Console.WriteLine("Input the max value to sum up to:");
            string input = Console.ReadLine();
            int max = 0;
            if (int.TryParse(input, out max))
                {
                Console.WriteLine("----------Solution 1:-----------");
                Solution1(max);
                Console.WriteLine("----------Solution 2:-----------");
                Solution2(max);
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public void Solution1(int max) //O(n)
        {
            int sum = 0;

            for (int i = 0; i < max; i++)
            {
                if (i % 3 == 0) { sum += i; }
                if (i % 5 == 0) { sum += i; }
            }
            Console.WriteLine("Sum: " + sum);
        }

        public void Solution2(int max)
        {
            int three = 0;
            int five = 0;
            int sum = 0;

            while (three < max)
            {
                sum += three;
                three += 3;
            }
            while (five < max)
            {
                sum += five;
                five += 5;
            }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
