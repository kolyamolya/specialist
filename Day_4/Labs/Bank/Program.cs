using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount NickAccount = new BankAccount("Nick");

            NickAccount.DepositNotify += PrintConsole;
            NickAccount.WithdrawNotify += PrintConsole;

            BankAccount SergeyAccount = new BankAccount("Sergey");

            SergeyAccount.DepositNotify += PrintConsole;
            SergeyAccount.WithdrawNotify += PrintConsole;

            NickAccount.Deposit(100100);

            BankAccount.Transfer(NickAccount, SergeyAccount, 29000);

            Console.WriteLine(SergeyAccount);
            Console.WriteLine(NickAccount);
        }

        public static void PrintConsole(String message) 
        {
            Console.WriteLine(message);
        }

    }
}
