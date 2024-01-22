using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractClass abstractClass = new AbstractClassDemo();
            abstractClass.print();

            InterfaceDemo interfaceDemo = new InterfaceClassDemo();
            interfaceDemo.print();

            Console.WriteLine("\nCollection..");
            List<string> list = new List<string>() { "Chaitanya", "Mohan" };
            foreach(string s in list)
            {
                Console.Write(s + " ");
            }
            list.Add("Harsha");
            Console.WriteLine("\n\nAfter adding 'Harsh'");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }
            list.Remove("Mohan");
            Console.WriteLine("\n\nAfter removing 'Mohan'");
            foreach (string s in list)
            {
                Console.Write(s + " ");
            }

            Console.WriteLine("\n\nExceptional Handling..");
            int a = 3;
            int b = 0;
            try
            {
                int c = a / b;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }

            Console.WriteLine("\nFile Handling..");
            FileHandling fileHandling = new FileHandling();
            //fileHandling.CreateFile();
            //fileHandling.DeleteFile();
            //fileHandling.WriteFile();
            //fileHandling.ReadFile();

            Console.ReadLine();
        }
    }
}
