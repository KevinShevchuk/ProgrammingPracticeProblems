using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class LargestPalindromeProduct
    {
    //A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    //Find the largest palindrome made from the product of two 3-digit numbers.

        public LargestPalindromeProduct()
        {
            Console.WriteLine("----------Solution 1:-----------");
            Solution1();
        }

        struct Products 
        {
            public int left;
            public int right;

            public Products(int l, int r)
            {
                left = l;
                right = r;
            }
        }

        public void Solution1()//0(n^2)
        {
            int palindrome = 999 * 999;
            while (true)
            {
                palindrome = NextPalindrome(palindrome);
                Products p = FindFactors(palindrome);
                if (p.left > 0 && p.right > 0)
                {
                    Console.WriteLine(p.left + " " + p.right);
                    break;
                }
            }
        }

        //Split number in half, reverse the first half and concatenate the result to the first half
        public int NextPalindrome(int value)
        {
            string firsthalf = value.ToString().Substring(0, value.ToString().Length / 2);
            int.TryParse(firsthalf, out int left);
            left -= 1;
            firsthalf = left.ToString() + ReverseNumber(left).ToString().PadLeft(3, '0');
            int.TryParse(firsthalf, out int full);
            return full;
        }

        public int ReverseNumber(int value)
        {
            int reverse = 0;
            while (value > 0)
            {
                int remainder = value % 10;
                reverse = (reverse * 10) + remainder;
                value = value / 10;
            }
            return reverse;
        }

        private Products FindFactors(int value)
        {
            int i = 999;
            while(i > 99)
                {
                if (value % i == 0)
                {
                    int val = value / i;
                    if (val > 99 && val < 999)
                    {
                        return new Products(i, val);
                    }
                }
                i--;
            }
            return new Products();
        }
    }
}
