using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {

        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }


        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.Balance = balance;

        }



        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} kr har lagts in på kontot");
            }
            else
            {
                Console.WriteLine("Insättningen misslyckad");
            }


        }

        public void Withdraw(decimal amount)
        {
            if (amount == Balance)
            {
                Console.WriteLine($"{amount} Godkänd uttag");

                Balance -= amount;
            }
            else if (amount <= Balance)
            {
                Console.WriteLine($"{amount} kr Godkänd uttag");

                Balance -= amount;

            }
            else if (amount >= Balance)
            {
                Console.WriteLine("Uttag misslyckad");
            }
        }



        public void DisplayInfo()
        {
            Console.WriteLine($"Kontonummer: {AccountNumber} Kortinnehavare: {AccountHolder} Saldo: {Balance}");

        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Aktuella saldot på kontot är {Balance}");


        }

    }
}
