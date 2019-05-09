using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace PracticeProblems
{
    class FactorialDigitSum
    {
        //n! means n * (n − 1) * ... * 3 * 2 * 1

        //For example, 10! = 10 * 9 * ... * 3 * 2 * 1 = 3628800,
        //and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.

        //Find the sum of the digits in the number 100!

        public FactorialDigitSum()
        {
            Console.WriteLine("Input the value to sum up the factorial digits to:");
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

        private long Solution1(int value)
        {
            BigInteger factorial = new BigInteger(value);
            for (long i = value - 1; i > 0; i--)
            {
                factorial *= i;
            }
            return SumDigits(factorial);
        }

        private long SumDigits(BigInteger input)
        {
            long sum = 0;
            while (input > 0)
            {
                BigInteger rem;
                BigInteger.DivRem(input, 10, out rem);
                sum += (int)rem;
                input = input / 10;
            }
            return sum;
        }
    }
}
