using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class OddEvenSplit
    {
        public static void ShowSplit()
        {
            /*
             * Create two lists with integer data type, one for even numbers, one for odd
             * Loop from 0-20
                * If number is even, add to even list
                * If number is odd, add to odd list
             * Print both lists
            */

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 21; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else 
                {
                    odd.Add(i);
                } 
            }

            Console.WriteLine("Even numbers");
            foreach (int i in even)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Odd numbers");
            foreach (int i in odd)
            {
                Console.WriteLine(i);
            }
        }
    }
}
