using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        //Lägg till Egenskaper (fields)
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        //Lägg till Konstruktor
        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            this.AccountNumber = accountNumber;
            this.AccountHolder = accountHolder;
            this.Balance = balance;

        }


        //Lägg till Metoder
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



        public void DisplayInfo()
        {
            Console.WriteLine($"Kontonummer: {AccountNumber} Kortinnehavare: {AccountHolder} Saldo: {Balance}");


            //Lycka till! :)
        }

    }
}
