using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LargestPrimeFactor
    {
        public LargestPrimeFactor()
        {
            Console.WriteLine("Input the number to find the largest prime factor up to:");
            string input = Console.ReadLine();
            ulong max = 0;
            if (ulong.TryParse(input, out max))
            {
                Console.WriteLine("----------Solution 1:-----------");
                Console.WriteLine(Solution1(max));
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public ulong Solution1(ulong value)//O(n^2)
        {
            ulong largest = 0;
            if (value >= 2)
                largest = 2;
            else
                return largest;

            ulong looplimit = (ulong)Math.Sqrt(value);
            for (ulong i = 3; i < looplimit; i += 2)
            {
                ulong sqrt = (ulong)Math.Sqrt(i);
                if (CheckPrime(i, sqrt))
                    largest = i;
            }
            return largest;
        }

        //Aborts early if it finds any divisor greater than 1
        private bool CheckPrime(ulong value, ulong divisor)
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
