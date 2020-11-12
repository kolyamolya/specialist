using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class BankAccount
    {

        public string Owner { get; private set; }
        public Decimal Balance { get; private set; }

        public event Action<string> DepositNotify;
        public event Action<string> WithdrawNotify;

        public BankAccount(string Owner)
        {
            this.Owner = Owner;
        }

        public void Deposit(Decimal summa) 
        {

            if (summa < 0)
            {
                DepositNotify?.Invoke($"{nameof(summa)} не может быть отрицательное число");
            }
            else
            {
                Balance += summa;

                DepositNotify?.Invoke($"Вы успешно пополнили на сумму {summa}\n" +
                    $"Ваш баланс равен {Balance}");
            }
        }

        public bool Withdraw(Decimal summa)
        {
            if (Balance < summa)
            {
                WithdrawNotify?.Invoke($"Недостаточно средста для списания");
                return false;
            }
            else 
            {
                Balance -= summa;
                WithdrawNotify?.Invoke($"Произошло снятие средств в размере {summa}\n" +
                    $"Ваш баланс равен {Balance}");

                return true;
            }
        }

        public static void Transfer(BankAccount source, BankAccount dest, Decimal summa) 
        {
            source.Withdraw(summa);
            dest.Deposit(summa);
        }

        public override string ToString()
        {
            return $"Owner : {Owner}; Balance : {Balance}";
        }

    }
}
