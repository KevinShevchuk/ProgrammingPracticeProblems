using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SumOfPrimes
    {
        public SumOfPrimes()
        {
            Console.WriteLine("Input the number to find the sum of primes up to:");
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

        public long Solution1(int value)//O(n^2)
        {
            int n = 0;
            if (value >= 2)
                n += 2;
            else
                return n;

            for (int i = 3; i < value; i += 2)
            {
                int sqrt = (int)Math.Sqrt(i);
                if (CheckPrime(i, sqrt)) n+= i;
            }
            return n;
        }

        //Aborts early if it finds any divisor greater than 1
        private bool CheckPrime(int value, int divisor)
        {
            if (value < 2)
                return false;
            if (value % 2 == 0)
                return false;
            if (value % divisor == 0)
            {
                if (divisor == 1)
                {
                    return true;
                }
                return false;
            }
            else
                return CheckPrime(value, divisor - 1);
        }
    }
}
