using System;

namespace Lab3
{
    class Start
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            string b;
            Console.Write("Account Name: ");
            b = Console.ReadLine();
            a.SetAccountName(b);
            Console.Write("Account ID: ");
            b = Console.ReadLine();
            a.SetAccountId(b);
            double c;
            Console.Write("Balance: ");
            c = Convert.ToDouble(Console.ReadLine());
            a.SetBalance(c);
            Console.Write("Deposit: ");
            c = Convert.ToDouble(Console.ReadLine());
            a.Deposit(c);
            a.ShowInfo();
            Console.Write("Withdraw: ");
            c = Convert.ToDouble(Console.ReadLine());
            a.Withdraw(c);
            a.ShowInfo();
        }
    }
}
