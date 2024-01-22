using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    interface InterfaceDemo
    {
        void print();
    }
    class InterfaceClassDemo : InterfaceDemo
    {
        public void print()
        {
            Console.WriteLine("\nInterface print method is overridden");
        }
    }
}
