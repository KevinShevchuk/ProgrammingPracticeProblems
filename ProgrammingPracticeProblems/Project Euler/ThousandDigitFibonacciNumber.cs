using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class ThousandDigitFibonacciNumber
    {
        //The Fibonacci sequence is defined by the recurrence relation:

        //Fn = Fn-1 + Fn-2, where F1 = 1 and F2 = 1.
        //Hence the first 12 terms will be:
        //F1 = 1
        //F2 = 1
        //F3 = 2
        //F4 = 3
        //F5 = 5
        //F6 = 8
        //F7 = 13
        //F8 = 21
        //F9 = 34
        //F10 = 55
        //F11 = 89
        //F12 = 144
        //The 12th term, F12 is the first term to contain three digits.

        //What is the first term in the Fibonacci sequence to contain 1000 digits?

        public ThousandDigitFibonacciNumber()
        {
            Console.WriteLine("----------Solution 1:-----------");
            Console.WriteLine(Solution1());
        }

        public long Solution1()
        {
            long index = 2;
            BigInteger limit = BigInteger.Pow(10, 999);
            BigInteger fibValue1 = new BigInteger(1);
            BigInteger fibValue2 = new BigInteger(1);

            while (fibValue2 < limit)
            {
                BigInteger fibValue3 = BigInteger.Add(fibValue1, fibValue2);
                fibValue1 = fibValue2;
                fibValue2 = fibValue3;
                index++;
            }
            return index;
        }
    }
}
