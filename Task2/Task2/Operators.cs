using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Operators
    {
        int a = 5;
        int b = 6;
        public void print()
        {
            Console.WriteLine("a = " + a + "\nb = " + b);
            Console.WriteLine("Arithmetic Operator (a + b): " + (a + b));
            a += 10;
            Console.WriteLine("Assignment Operator (a += 10): a = " + a);
            Console.WriteLine("Comparision Operator (a > b): " + (a > b));
            Console.WriteLine("Comparision Operator (!true): " + (!true));
        }
    }
}
