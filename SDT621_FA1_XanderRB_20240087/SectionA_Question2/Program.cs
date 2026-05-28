using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SectionA_Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Hardcoded initial balance for simulation
            double currentBalance = 5000.00;


            // Decorative Header
            Console.WriteLine("==================================================");
            Console.WriteLine("             ATM BANKING SIMULATION               ");
            Console.WriteLine("==================================================");
            Console.WriteLine($"Current Available Balance: R{currentBalance:F2}");
            Console.WriteLine("==================================================");
            Console.WriteLine();

            bool isTransactionComplete = false;

            while (!isTransactionComplete)
            {
                //Prom[ptp user \for withdrawl amount
                Console.Write("Enter the amount you wish to withdraw: R");
                string input = Console.ReadLine();

                //Numeric validation (Defensive)
                if (double.TryParse(input, out double withdrawalAmount))
                {

                    //Business Logic Validation
                    if (withdrawalAmount <= 0)
                    {
                        Console.WriteLine("Error: Withdrawl amount must be greater than zero.\n");
                    }

                    // DECISION STRUCTURE check for suffient funds
                    else if (withdrawalAmount > currentBalance)
                    {
                        Console.WriteLine("Transaction Failed: Insufficient funds in your account.\n");
                    }
                    else
                    {
                        //Process Transaction
                        currentBalance -= withdrawalAmount; //deduct funds
                        isTransactionComplete = true; //break loop

                        //Output Formatting
                        Console.WriteLine("\n==================================================");
                        Console.WriteLine("               TRANSACTION RECEIPT                ");
                        Console.WriteLine("==================================================");
                        Console.WriteLine("Status             : Approved");
                        Console.WriteLine($"Amount Withdrawn   : R{withdrawalAmount:F2}");
                        Console.WriteLine($"Remaining Balance  : R{currentBalance:F2}");
                        // Captures and formats the exact current system date and time
                        Console.WriteLine($"Transaction Time   : {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                        Console.WriteLine("==================================================");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid numeric amount.\n");
                }
            }

            //Keep Console Open for Screenshots
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
