using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount a = new SavingAccount("Meher", 100.00, 100005);
            Console.WriteLine("Saving Account");
            a.AddBalance(100);
            a.Interest();
            a.Withdraw(50.0);
            a.ShowBalance();

            CheckingAccount b = new CheckingAccount("Hridoy", 250.0, 500010);
            Console.WriteLine("Checking Account");
            b.AddBalance(600.0);
            b.OrderCheck();
            b.Withdraw(100.0);
            b.ShowBalance();
        }
    }
}
