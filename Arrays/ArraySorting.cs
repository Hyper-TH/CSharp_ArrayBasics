using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArraySorting
    {
        public static void ShowArraySorting()
        {
            int[] numbers = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9
            };

            string test = "";
            test.Replace(" ", "");

            // Sort numbers without having to re-store them
            Array.Sort(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            // Store the sorted version without affecting original state
            // Using copy...
            int[] sortedNumbers = new int[numbers.Length];

            Array.Copy(numbers, sortedNumbers, numbers.Length);
            Array.Sort(sortedNumbers);

            // Using clone...
            int[] sortedNumbers2 = (int[])numbers.Clone();

            Array.Sort(sortedNumbers2);

            // Using Linq...
            int[] sortedNumbers3 = numbers.OrderBy(x => x).ToArray();

        }
    }
}
