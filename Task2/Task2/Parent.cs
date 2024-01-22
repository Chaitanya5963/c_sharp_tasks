using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Parent
    {
        public void parent()
        {
            Console.WriteLine("Parent Class method is called..");
        }
        public virtual void overriding()
        {
            Console.WriteLine("Parent class method");
        }
        public void add(int a, int b)
        {
            Console.WriteLine("Addition of a(int) and b(int) is " + (a + b));
        }
        public void add(int a, float b)
        {
            Console.WriteLine("Addition of a(int) and b(float) is " + (a + b));
        }
        public void add(double a, long b)
        {
            Console.WriteLine("Addition of a(double) and b(long) is " + (a + b));
        }
    }
}
