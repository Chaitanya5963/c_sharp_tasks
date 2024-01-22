using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("DataTypes..\n");       Example for single line comment.

            /*DataTypes dataTypes = new DataTypes();    Example for multiple line comment.
            dataTypes.print();*/

            Console.WriteLine("DataTypes..\n");
            DataTypes dataTypes = new DataTypes();
            dataTypes.print();

            Console.WriteLine("\nTypeCasting..\n");
            TypeCasting typeCasting = new TypeCasting();
            typeCasting.print();

            Console.WriteLine("\nOperators..\n");
            Operators operators = new Operators();
            operators.print();

            Console.WriteLine("\nControl Statements..\n");
            ControlStatements controlStatements = new ControlStatements();
            controlStatements.print();

            Console.WriteLine("\nArrays..");
            Arrays arrays = new Arrays();
            arrays.print();

            Console.WriteLine("\nConstructors..");
            Demo demoObj1 = new Demo();
            Demo demoObj2 = new Demo(6);
            demoObj1.printDemo();
            demoObj2.printDemo();

            Console.WriteLine("\nInheritance..");
            Child child = new Child();
            child.parent();

            Console.WriteLine("\nPolymorphism..");
            Console.WriteLine("\nOverloading");
            Parent parent = new Parent();
            parent.add(4, 6);
            parent.add(7, 5.8F);
            parent.add(48.354D, 654L);
            Console.WriteLine("\nOverriding");
            Parent parentObj = new Child();
            parentObj.overriding();

            Console.ReadLine();
        }
    }
}
