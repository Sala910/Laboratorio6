using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    using System;

    public class BankAccount
    {
        public string AccountNumber { get; }
        private float balance;

        public BankAccount(string accountNumber, float balance = 0.0f)
        {
            if (balance < 0)
                throw new ArgumentException("Начальный баланс не может быть отрицательным.");
            AccountNumber = accountNumber;
            this.balance = balance;
        }

        public void Deposit(float amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма для пополнения должна быть больше 0.");
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма для снятия должна быть больше 0.");
            if (amount > balance)
                throw new InvalidOperationException("Недостаточно средств.");
            balance -= amount;
        }

        public float GetBalance()
        {
            return balance;
        }
    }

}
