using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class SpecialPythagoreanTriplet
    {
        //A Pythagorean triplet is a set of three natural numbers, a < b<c, for which,

        //a^2 + b^2 = c^2
        //For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.

        //There exists exactly one Pythagorean triplet for which a + b + c = 1000.
        //Find the product abc.

        public SpecialPythagoreanTriplet()
        {
            Console.WriteLine("----------Solution 1:-----------");
            Console.WriteLine(Solution1());
        }

        public int Solution1()//O(n^2)
        {
            int[] powers = new int[1000];

            for ( int i = 0; i < 1000; i++ )
            {
                powers[i] = i * i;
            }

            for (int c = 499; c > 0; c--) 
            {
                for (int b = 1; b < (1000 - c); b++)
                {
                    int a = 1000 - (c + b);

                    if ((a + b + c == 1000) && (powers[c] == powers[b] + powers[a]))
                    {
                        Console.WriteLine(a + ", " + b + ", " + c);
                        return a * b * c;
                    }
                }
            }
            return 0;
        }
    }
}
