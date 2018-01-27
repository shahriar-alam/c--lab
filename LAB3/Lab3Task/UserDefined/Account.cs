using System;
namespace AccountUserDefined
{
    public class Account
    {
        string accName, accid;
        double balance;

        public Account()
        {
            accName = accid = " ";
            balance = 0.0;
        }
        public Account(string accName, string accid, double balance)
        {
            this.accName = accName;
            this.accid = accid;
            this.balance = balance;
        }
        public string AccName
        {
            set
            {
                this.accName = value;
            }
            get
            {
                return this.accName;
            }
        }
        public string AccId
        {
            set
            {
                this.accid = value;
            }
            get
            {
                return this.accid;
            }
        }
        public double Balance
        {
            set
            {
                this.balance = value;
            }
            get
            {
                return this.balance;
            }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Transfer(double amount, Account a)
        {
            balance -= amount;
            a.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }
        public void ShowInfo()
        {
            Console.WriteLine("\nAccount Name: " + AccName + "\nAccID: " + AccId + "\nBalance: " + Balance);
        }
    }
}
