using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zookeeper
{
    class Elephant:Animal,ISleepable
    {
        public void IsHungry()
        {
            Console.WriteLine("Is the elephant hungry?(y/n)");
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
                Console.WriteLine("Enter the quantity of grass: ");
                double quan = Convert.ToDouble(Console.ReadLine());
                this.quantity += quan;
                Console.WriteLine("Total quantity of grass: " + quantity);
                Sleep();
            }
            else
                Console.WriteLine("The elephant is not hungry");
        }
        public void Sleep()
        {
            Console.WriteLine("The elephant is now sleeping");
        }
    }
}
