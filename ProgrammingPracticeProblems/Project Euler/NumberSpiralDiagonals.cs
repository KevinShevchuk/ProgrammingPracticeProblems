using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class NumberSpiralDiagonals
    {
        //Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:

        //21 22 23 24 25
        //20  7  8  9 10
        //19  6  1  2 11
        //18  5  4  3 12
        //17 16 15 14 13

        //It can be verified that the sum of the numbers on the diagonals is 101.

        //What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
        public NumberSpiralDiagonals()
        {
            Console.WriteLine("Input the side length of the spiral:");
            string input = Console.ReadLine();
            int max = 0;
            if (int.TryParse(input, out max))
            {
                if (max % 2 == 0)
                {
                    Console.WriteLine("Side length must be an odd number.");
                }
                else
                {
                    Console.WriteLine("----------Solution 1:-----------");
                    Console.WriteLine(Solution1(max));
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public int Solution1(int sidelength)
        {
            int bRight = 1;
            int bLeft = 1;
            int tLeft = 1;
            int tRight = 1;

            int increment = 2;
            int multiplier = 0;
            int currentSideLength = 1;
            int sum = 1;
            //looking at the grid above each diagonal is increasing by n+2 over the previous one of that corner.
            while(currentSideLength <= sidelength)
            {
                bRight += (multiplier + increment); multiplier += increment;
                bLeft += (multiplier + increment); multiplier += increment;
                tLeft += (multiplier + increment); multiplier += increment;
                tRight += (multiplier + increment); multiplier += increment;
                sum += (bRight + bLeft + tLeft + tRight);
                currentSideLength += 2;
            }
            return sum;
        }
    }
}
