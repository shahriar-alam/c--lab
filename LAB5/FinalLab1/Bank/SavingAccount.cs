using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingAccount:Account
    {
        public SavingAccount()
        {

        }
        public SavingAccount(string name, double balance, int number)
        {
            if (number >= 100000)
            {
                if (NumberList.Contains(number))
                {
                    Console.WriteLine("Account number already exists");
                }
                else
                {
                    this.name = name;
                    this.balance = balance;
                    this.number = number;
                    NumberList.Add(number);
                }
            }
        }
        public void Interest()
        {
            if (balance > 10000)
                Console.WriteLine("Interest: " + balance * 0.06);
            else
                Console.WriteLine("Interest: " + balance * 0.03);
        }
        public void ShowBalance()
        {
            Console.WriteLine("Account Balance: " + balance );

        }
        public void AddBalance(double balance)
        {
            this.balance += balance;
        }
        public void Withdraw(double balance)
        {
            if (this.balance < balance)
            {
                Console.WriteLine("Not enough balance");
            }
            else
            {
                this.balance -= balance;
            }
        }

    }
}
