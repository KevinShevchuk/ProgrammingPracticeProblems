using System;
using System.Linq;

//Pooja would like to withdraw X $US from an ATM.The cash machine will only accept the transaction if X is a multiple of 5, and Pooja's account balance has enough cash to perform the withdrawal transaction (including bank charges). For each successful withdrawal the bank charges 0.50 $US. Calculate Pooja's account balance after an attempted transaction.

//Input
//Positive integer 0 < X <= 2000 - the amount of cash which Pooja wishes to withdraw.

//Nonnegative number 0<= Y <= 2000 with two digits of precision - Pooja's initial account balance.

//Output
//Output the account balance after the attempted transaction, given as a number with two digits of precision.If there is not enough money in the account to complete the transaction, output the current bank balance.

//Example - Successful Transaction
//Input:
//30 120.00

//Output:
//89.50
//Example - Incorrect Withdrawal Amount (not multiple of 5)
//Input:
//42 120.00

//Output:
//120.00
//Example - Insufficient Funds
//Input:
//300 120.00

//Output:
//120.00

namespace PracticeProblems
{
    class ATM
    {
        public ATM()
        {
            Console.WriteLine("Input the amount to withdraw followed by the balance of the account as a float:");
            string input = Console.ReadLine();

            string[] splitInput = input.Split(' ');
            if (splitInput.Count() == 2)
            {
                int.TryParse(splitInput[0], out int amt);
                float.TryParse(splitInput[1], out float balance);
                if (amt > 0 && amt <= 2000 && balance >= 0 && balance <= 2000 && amt % 5 == 0 && balance > amt)
                {
                    Console.WriteLine(string.Format("{0:C2}", Solution1(amt, balance)));
                }
                else
                {
                    Console.WriteLine("Invalid Input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }

        public float Solution1(int amt, float balance)
        {
            return balance - amt;
        }
    }
}
