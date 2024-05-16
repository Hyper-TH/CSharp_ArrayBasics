using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayIndexOf
    {
        public static void ShowArrayIndexOf()
        {
            int[] numbers = new int[]
            {
                99, 199, 22, 50, 30
            };

            Console.WriteLine("Enter number to search: ");
            int search = Convert.ToInt32(Console.ReadLine());

            // Return first instance
            // int position = Array.IndexOf(numbers, search);
            int position = Array.IndexOf(numbers, search, 1, 2);   // Start from 1st index to 2nd index

            // int position = -1;

            /*
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]  == search) 
                {
                    position = i;
                }
            }
            */

            if (position > -1)  // 0 -> 
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");
            }
            else
            {
                Console.WriteLine($"Number {search} has not been found");
            }
        }
    }
}
