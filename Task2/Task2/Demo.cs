using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Demo
    {
        int a;
        public Demo()
        {
            a = 5;
        }
        public Demo(int b)
        {
            a = b;
        }
        public void printDemo()
        {
            Console.WriteLine("The value of a is " + a);
        }
    }
}
