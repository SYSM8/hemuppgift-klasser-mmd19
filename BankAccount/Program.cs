namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // // Instansiera bankAccount klassen och testa den
            BankAccount myBankAccount = new BankAccount("123456789", "Alex", 500);

            myBankAccount.DisplayInfo();


            myBankAccount.Deposit(200);
            myBankAccount.Deposit(0);

            myBankAccount.DisplayBalance();

            myBankAccount.Withdraw(200);

            myBankAccount.DisplayBalance();

            myBankAccount.Withdraw(400);

            myBankAccount.DisplayBalance();

            myBankAccount.Withdraw(700);


            myBankAccount.DisplayBalance();






        }


    }
}
