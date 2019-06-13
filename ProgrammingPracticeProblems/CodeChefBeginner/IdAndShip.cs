using System;
using System.Collections.Generic;

namespace PracticeProblems
{
	class IdAndShip
	{
        private Dictionary<char, string> _lookup = new Dictionary<char, string>()
        {
            { 'B', "Battleship"},
            { 'C', "Cruiser" },
            { 'D', "Destroyer" },
            { 'F', "Frigate" }
        };

        public IdAndShip()
        {
            Console.WriteLine("Input the number of tests:");
            string input = Console.ReadLine();
            bool success = int.TryParse(input, out int numberOfTests);
            if (success && numberOfTests >= 1 && numberOfTests <= 100)
            {
                string[] results = new string[numberOfTests];
                int inputs = 0;
                while (inputs < numberOfTests)
                {
                    Console.WriteLine("Enter the Id:");
                    string testInput = Console.ReadLine().ToUpper();
                    char test = testInput[0];
                    if (test >= 'A' && test <= 'Z')
                    {

                        results[inputs] = Solution1(test);
                        inputs++;
                    }
                }
                foreach (string i in results)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        private string Solution1(char input)
        {
            return _lookup[input];
        }
    }
}
