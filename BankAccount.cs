using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankingSystem
{
    public class BankAccount
    {

        //Main properties

        //Private accessable to all 
        private static string __bankName = "The Bizzare Bank";
        public static string BankName=> __bankName;
        //Public
        public string AccountHolder { get;}

        //encapsulated
        private decimal __balance;

        

        //protected
        private List<Transaction> __transactions = new();
        public ReadOnlyCollection<Transaction> Transactions=> __transactions.AsReadOnly();

        //Constructor

        public BankAccount(string accountholder,decimal balance=0)
        {
            AccountHolder = accountholder;
            if(balance < 0)
            { throw new ArgumentException("Intial balance cannot be negative!"); }
            __balance = balance;
        }


        //Deposite method

        public void deposite(decimal amount)
        {
            if(amount<=0)
            {
                Console.WriteLine($"Amount must be positive, {amount} is not positve!");
                return;
            }
            __balance+=amount;

            //Record the transaction
            __transactions.Add(new Transaction(amount, "Deposite"));

            Console.WriteLine($" Deposited ${amount:N2}. Balance: ${__balance:N2}");

        }

        //Get balance
        public decimal getBalance() { return __balance; }

        //Withdraw method

        public void withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Amount must be positive, {amount} is not positve!");
                return;
            }
            if (amount > __balance)
            {
                Console.WriteLine($"Incufficient Amount. Current Balanec : {getBalance()}");
                return;
            }

            __balance -= amount;

            __transactions.Add(new Transaction(amount, "Withdrawl"));
            Console.WriteLine($" Withdrew ${amount:N2}. Balance: ${__balance:N2}");

        }

        //Change Bank name

        public void change_BankName(string bankName)
            { __bankName = bankName; }
    }
}
