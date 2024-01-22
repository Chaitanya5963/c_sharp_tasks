using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class TypeCasting
    {
        bool b = true;
        char c = 'c';   //Implicit Casting
        int i = 1;
        long l = 2L;
        float f = 2.5F;
        double d = 5.5D;
        string s = "Chaitanya";
        public void print()
        {
            long l = 123L;
            double d = l;
            Console.WriteLine("Example for Implicit Casting (long to double) : "+d);
            int i = 97;
            char c = (char)i;
            Console.WriteLine("Example for Explicit Casting (int to char) : " + c);

            string s = "true";
            bool b = Convert.ToBoolean(s);
            Console.WriteLine("Example for Implicit Casting using Type convertion methods (string to bool) : " + b);
        }
    }
}
