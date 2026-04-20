using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace BankingSystem
{
    public class Program
    {
        static BankAccount? currentAccount;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Account holder Name: ");
            string holderName=Console.ReadLine()?? "Guest";
            currentAccount = new BankAccount(holderName);
            Console.WriteLine($"Welcome to {BankAccount.BankName}");
            bool run = true;
            while (run)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Print Statement");
                Console.WriteLine("5. Change Bank Name");
                Console.WriteLine("6. Exit");
                string choice = Console.ReadLine() ??"";

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: $");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            currentAccount.deposite(depositAmount);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case "2":
                        Console.Write("Enter withdrawal amount: $");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            currentAccount.withdraw(withdrawAmount);
                        else
                            Console.WriteLine("Invalid amount.");
                        break;

                    case "3":
                        Console.WriteLine($"Current Balance: ${currentAccount.getBalance():N2}");
                        break;

                    case "4":
                        Console.WriteLine($"\n--- Statement for {currentAccount.AccountHolder} ---");
                        foreach (Transaction t in currentAccount.Transactions)
                        {
                            t.DisplayDetails();
                        }
                        Console.WriteLine($"Current Balance: ${currentAccount.getBalance():N2}");
                        break;

                    case "5":
                        Console.Write("Enter new bank name: ");
                        string newName = Console.ReadLine() ?? "";
                        if (!string.IsNullOrEmpty(newName))
                        {
                            currentAccount.change_BankName(newName);
                            Console.WriteLine($"Bank name changed to: {BankAccount.BankName}");
                        }
                        else
                            Console.WriteLine("Bank name cannot be empty.");
                        break;

                    case "6":
                        run = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 1-6.");
                        break;
                }
            }
        }
    }
}

