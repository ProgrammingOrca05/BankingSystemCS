using System;


namespace BankingSystem
{
    public class Transaction
    {
        //get only (constructor job)
        public decimal Amount { get; }
        public string Type { get; }
        public DateTime Date {  get; }

        //Constructor
        public Transaction(decimal amount, string type)
        {
            Amount = amount;
            Type = type;
            Date = DateTime.Now;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($" [{Date:yyyy-MM-dd HH:mm:ss}] {Type,-12} ${Amount:N2}");
        }


    }
}
