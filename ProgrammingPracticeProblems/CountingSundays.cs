using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    class CountingSundays
    {
        public CountingSundays()
        {
            Console.WriteLine("----------Solution 1:-----------");
            Console.WriteLine(Solution1());
        }

        private enum DaysTillSunday
        {
            Monday = 6,
            Tuesday = 5,
            Wednesday = 4,
            Thursday = 3,
            Friday = 2,
            Saturday = 1, 
            Sunday = 0
        }

        private int Solution1()
        {
            int year = 1901;
            int day = 1;
            int month = 1;
            DaysTillSunday DayOfWeek = DaysTillSunday.Monday;

            int count = 0;

            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            while (year < 2000)
            {
                if (DayOfWeek != DaysTillSunday.Sunday)
                {
                    day += (int)DayOfWeek;
                    DayOfWeek -= DayOfWeek;
                }
                else
                {
                    if (day == 1 && DayOfWeek == DaysTillSunday.Sunday)
                    {
                        count++;
                    }
                    if (day + 7 > daysInMonth[month-1])
                    {
                        day = ((day + 7) - daysInMonth[month-1]);
                        if (month == 12)
                        {
                            month = 1;
                            year++;
                        }
                        else
                        {
                            month++;
                        }
                    }
                    else
                    {
                        day += 7;
                    }
                }
            }
            return count;
        }
    }
}
