using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Multiples
    {
        public static void ShowMultiples()
        {
            /*
             * Define and initialize two integers (num, length)
             * (7, 5) -> [7, 14, 21, 28, 35]
             * Create int array with size length
             * Loop through and insert the (loop counter x num) into the array
             * Print the final array
            */

            const int num = 5;
            const int length = 10;

            int[] nums = new int[length];

            for (int i = 0; i < length; i++)
            {
                nums[i] = i * num;
            }

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i} x {num} = {nums[i]}");
            }
        }
    }
}
