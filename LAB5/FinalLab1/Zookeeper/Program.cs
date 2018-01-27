using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zookeeper
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Elephant();
            a.Eat();
            a = new Cat();
            a.Eat();
        }
    }
}
