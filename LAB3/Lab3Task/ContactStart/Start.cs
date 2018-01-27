using System;
using ContactUserDefined;
namespace ContactStart
{
    class Start
    {
        static void Main(string[] args)
        {
            Contact c1 = new Contact();

            c1.PersonName = "A";
            c1.PersonId = "1";
            c1.Gender = 'M';
            c1.MobileNumber = "01700000000";
            c1.Age = 20;

            Contact c2 = new Contact("B", "2", 25, "01800000000", 'F');

            c1.ShowPersonInfo();
            c2.DetectMobileOperator();
        }
    }
}
