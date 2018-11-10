using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LongestCollatzSequence
    {
        //The following iterative sequence is defined for the set of positive integers:

        //n → n/2 (n is even)
        //n → 3n + 1 (n is odd)

        //Using the rule above and starting with 13, we generate the following sequence:

        //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        //Which starting number, under one million, produces the longest chain?

        long[] solved = new long[1000000]; //cache. Once we reach any previously solved number we can just check the cache and add its value to the current.

        public LongestCollatzSequence()
        {
            int max = 1000000;
            Console.WriteLine("----------Solution 1:-----------");
            Console.WriteLine(Solution1(max));
        }

        private long Solution1(int max) //O(n log n)
        {
            
            long longest = 0;
            long current = 0;
            for (long i = 13; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    current = Even(i, 0);
                }
                else
                {
                    current = Odd(i, 0);
                }
                solved[i] = current;
                if (current > longest)
                    longest = current;
            }
            return longest;
        }

        private long Even(long num, int steps)
        {
            num /= 2;
            if (num < 1000000 && solved[num] > 0)
                return steps + solved[num];
            if (num % 2 == 0)
                return Even(num, steps + 1);
            else
                return Odd(num, steps + 1);
        }

        private long Odd(long num, int steps)
        {
            if (num == 1)
                return steps;
            num = (3 * num) + 1;
            if (num < 1000000 && solved[num] > 0)
                return steps + solved[num];
            if (num % 2 == 0)
                return Even(num, steps + 1);
            else
                return Odd(num, steps + 1);
        }
    }
}
