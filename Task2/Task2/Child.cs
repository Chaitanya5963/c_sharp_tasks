using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Child : Parent
    {
        public void child()
        {
            Console.WriteLine("Child Class method is called..");
        }
        public override void overriding()
        {
            Console.WriteLine("Child class method");
        }
    }
}
