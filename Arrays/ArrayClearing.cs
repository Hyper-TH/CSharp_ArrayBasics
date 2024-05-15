using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayClearing
    {
        public static void ShowArrayClearing()
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            // Clear(array, start, count up to end)
            // Assign all values to 0
            
            Array.Clear(numbers, 0, numbers.Length);

            // Equivalent in for loop
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = default;
            }

            
            Array.Clear(numbers, 5, 5);

            // To position 9
            for (int i = 5; i < 10; i++)    // 5 6 7 8 9
            {
                numbers[i] = default;
            }


            foreach (int i in numbers)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
