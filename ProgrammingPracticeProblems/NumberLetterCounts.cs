using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class NumberLetterCounts
    {
        public NumberLetterCounts()
        {
            Console.WriteLine("----------Solution 1:-----------");
            Console.WriteLine(Solution1());
        }

        private int Solution1()
        {
            //building our lookup values
            int oneToTen = 3 + 3 + 5 + 4 + 4 + 3 + 5 + 5 + 4;
            int elevenToNineteen = 3 + 6 + 6 + 8 + 8 + 7 + 7 + 9 + 8 + 8;
            int[] tens = new int[8] { 6, 6, 5, 5, 5, 7, 6, 6 };
            //expand to numbers between 19 and 100.
            int twentyTo99 = 0;
            for (int i = 0; i < tens.Length -1; i++)
            {
                twentyTo99 += 10 * tens[i] + oneToTen;
            }
            //expand to numbers between 99 and 1000
            int oneHundredTo999 = 0;
            int[] ones = new int[9] { 3, 3, 5, 4, 4, 3, 5, 5, 4 };
            for (int i = 0; i < ones.Length - 1; i++)
            {
                oneHundredTo999 += 100 * (ones[i] + 7) + 99*3 + oneToTen + elevenToNineteen + twentyTo99;
            }
            //Get final answer
            return oneToTen + elevenToNineteen + twentyTo99 + oneHundredTo999 + 11;
        }
    }
}
