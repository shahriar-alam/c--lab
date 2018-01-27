using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zookeeper
{
    class Cat:Animal,ISleepable
    {
        public void IsHungry()
        {
            Console.WriteLine("Is the cat hungry?(y/n)");
            string a = Console.ReadLine();
            if (a.Equals("y"))
                hungry = true;
            else
                hungry = false;
        }
        override public void Eat()
        {
            IsHungry();
            if (hungry == true)
            {
                Console.WriteLine("Enter the quantity of protein: ");
                double quan = Convert.ToDouble(Console.ReadLine());
                this.quantity += quan;
                this.quantity += quantity;
                Console.WriteLine("Total quantity of protein: " + quantity);
                Sleep();
            }
            else
                Console.WriteLine("The cat is not hungry");
        }
        public void Sleep()
        {
            Console.WriteLine("The cat is now sleeping");
        }
    }
}
