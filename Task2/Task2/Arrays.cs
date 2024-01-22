using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Arrays
    {
        int[] arr = {1,2,3,4,5,6};
        public void print()
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i+" ");
            }
            arr[3] = 10;
            Console.WriteLine("\nArray after assigning a particular value at a particular position");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
