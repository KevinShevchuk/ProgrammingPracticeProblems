using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
    //What is the 10 001st prime number?

    class NthPrime
    {
        public NthPrime()
        {
            Console.WriteLine("Input the N to find the Nth prime number:");
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
            int n = 1;
            for (int i = 3; n < value; i+=2)
            {
                int sqrt = (int)Math.Sqrt(i);
                if (CheckPrime(i, sqrt)) n++;
                if (n == value) return i;
            }
            return 0;
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
