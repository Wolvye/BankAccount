using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class BankAccount
    {
        public string Number { get; private set; }
        public string Owner { get; private set; }
        public float Balance { get; private set; }
        public BankAccount(string number, string owner, float initalBalance)
        {
            Number = number;
            Owner = owner;
            Balance = initalBalance;
        }
        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }
        public void MakeWithdrawal(float amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Not enough money in the account");
            }
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Account number: {Number}");
            Console.WriteLine($"Account owner: {Owner}");
            Console.WriteLine($"Account balance: {Balance}");
        }
    }
}
