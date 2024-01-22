using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class AbstractClass
    {
        public abstract void print();
    }
    class AbstractClassDemo : AbstractClass
    {
        public override void print()
        {
            Console.WriteLine("\nAbstract Class print method is overridden");
        }
    }
}
