using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zookeeper
{
    abstract class Animal
    {
        protected bool hungry;
        protected double quantity = 0;
        abstract public void Eat();
    }
}
