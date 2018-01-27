using System;
namespace ContactUserDefined
{
    public class Contact
    {
        string personName, personId, mobileNumber;
        int age;
        char gender;

        public Contact()
        {
            personName = personId = mobileNumber = " ";
            age = 20;
            gender = ' ';
        }
        public Contact(string personName, string personId, int age, string mobileNumber, char gender)
        {
            this.personName = personName;
            this.personId = personId;
            this.age = age;
            this.mobileNumber = mobileNumber;
            this.gender = gender;
        }
        public string PersonName
        {
            set
            {
                this.personName = value;
            }
            get
            {
                return this.personName;
            }
        }
        public string PersonId
        {
            set
            {
                this.personId = value;
            }
            get
            {
                return this.personId;
            }
        }
        public string MobileNumber
        {
            set
            {
                this.mobileNumber = value;
            }
            get
            {
                return this.mobileNumber;
            }
        }
        public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
        }
        public char Gender
        {
            set
            {
                this.gender = value;
            }
            get
            {
                return this.gender;
            }
        }
        public void ShowPersonInfo()
        {
            Console.WriteLine("\nName: "+PersonName+"\nID: "+PersonId+"\nGender: "+Gender+"\nMobile Number: "+MobileNumber+"\nAge: "+Age);
        }
        public void DetectMobileOperator()
        {
            if (mobileNumber.StartsWith("015"))
            {
                Console.WriteLine("Teletalk");
            }
            else if (mobileNumber.StartsWith("016"))
            {
                Console.WriteLine("Airtel");
            }
            else if (mobileNumber.StartsWith("017"))
            {
                Console.WriteLine("GrameenPhone");
            }
            else if (mobileNumber.StartsWith("018"))
            {
                Console.WriteLine("Robi");
            }
            else if (mobileNumber.StartsWith("019"))
            {
                Console.WriteLine("Banglalink");
            }
        }
    }
}
