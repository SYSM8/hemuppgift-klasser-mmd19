namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instansiera bankAccount klassen och testa den
            BankAccount myBankAccount = new BankAccount("123456789", "Alex", 200);

            myBankAccount.DisplayInfo();

            myBankAccount.Deposit(200);
            myBankAccount.Deposit(0);



        }


    }
}
