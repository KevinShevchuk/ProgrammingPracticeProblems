using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SmallestMultiple
    {
        public SmallestMultiple()
        {
            Console.WriteLine("Input the max value to sum up to:");
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

        private long Solution1(int max)
        {
            long maxval = long.MaxValue;
            long increment = max * (max - 1);
            for (long i = increment; i < maxval; i += increment)
            {
                long val = TestMultiple(i, max - 1);
                if (val > 0) return val;
            }
            return 0;
        }

        private long TestMultiple(long value, long divisor)
        {
            if (divisor == 1) return value;
            else 
            {
                if (value % divisor == 0)
                {
                    return TestMultiple(value, divisor - 1);
                }
                return 0;
            }
        }
    }
}
