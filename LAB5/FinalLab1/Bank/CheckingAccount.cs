using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckingAccount:Account
    {
        bool check = false;
        public CheckingAccount()
        {
        }
        public CheckingAccount(string name, double balance, int number)
        {
            if (number >= 500000)
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
        public void OrderCheck()
        {
            check = true;
        }
        public void ShowBalance()
        {
            Console.WriteLine("Account Balance: " + balance + "\nCheck ordered: "+ check);
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
