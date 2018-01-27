using System;

namespace Lab3
{
    class Account
    {
        string accountName, accountId;
        double balance;

        public void SetAccountName(string accountName)
        {
            this.accountName = accountName;
        }
        public void SetAccountId(string accountId)
        {
            this.accountId = accountId;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        public string GetAccountName()
        {
            return accountName;
        }
        public string GetAccountId()
        {
            return accountId;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void Deposit(double balance)
        {
            this.balance += balance;
        }
        public void Withdraw(double balance)
        {
            this.balance -= balance;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Name: " + GetAccountName() + "\nID: " + GetAccountId() + "\nBalance: " + GetBalance());
        }

    }
}
