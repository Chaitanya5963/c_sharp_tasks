using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITGTraining24
{
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass obj = new MyFirstClass();
            obj.s = Console.ReadLine();
            Console.WriteLine("The result is "+obj.s);
            Console.ReadLine();
        }
    }
}
