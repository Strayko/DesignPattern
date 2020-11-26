using JetBrains.Annotations;

namespace NullObject.Example
{
    public class BankAccount
    {
        private ILog log;
        private int balance;

        public BankAccount(ILog log)
        {
            this.log = log;
        }

        public void Deposit(int amount)
        {
            balance += amount;
            log.Info($"Deposited {amount}, balance is now {balance}");
        }
    }
}