using System;
using AccountUserDefined;
namespace AccountStart
{
    class Start
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            Account b = new Account("BBBB", "2", 200.00);

            a.AccName = "A";
            a.AccId = "1";
            a.Balance = 200.00;

            a.Deposit(100.00);
            a.Withdraw(150.00);

            a.Transfer(50.00, b);

            a.ShowInfo();
            b.ShowInfo();
        }
    }
}
