using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class ControlStatements
    {
        public void print()
        {
            Console.Write("Enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIf Else example:");
            if (a > b)
            {
                Console.WriteLine(a + " is greater than " + b);
            }
            else
            {
                Console.WriteLine(b + " is greater than " + a);
            }
            Console.WriteLine("\nSwitch case example:");
            Console.WriteLine("Arithmetic Operators:\n1.Addition\n2.Substraction\n3.Multiplication\n4.Division");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1: Console.WriteLine("Addition of a and b is "+(a + b));break;
                case 2: Console.WriteLine("Substraction of a and b is " + (a - b)); break;
                case 3: Console.WriteLine("Multiplication of a and b is " + (a * b)); break;
                case 4: Console.WriteLine("Division of a and b is " + (a / b)); break;
                default: Console.WriteLine("Invalid entry");break;
            }
            Console.WriteLine("\nPrinting upto 10 numbers using while loop");
            int i = 1;
            while(i <= 10)
            {
                Console.Write(i+" ");
                i++;
            }
            Console.WriteLine("\n\nPrinting upto 10 numbers using for loop");
            for (i=1;i<=10;i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
