using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class ArrayReversal
    {
        public static void ShowArrayReversal()
        {
            int[] numbers = new int[]
            {
                0, 1, 2, 3, 4, 5
            };

            // Sort numbers without having to re-store them
            Array.Reverse(numbers);

            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            // Store the sorted version without affecting original state
            // Using copy...
            int[] sortedNumbers = new int[numbers.Length];

            Array.Copy(numbers, sortedNumbers, numbers.Length);
            Array.Reverse(sortedNumbers);

            // Using clone...
            int[] sortedNumbers2 = (int[])numbers.Clone();

            Array.Reverse(sortedNumbers2);

            // Using Linq...
            int[] sortedNumbers3 = numbers.OrderByDescending(x => x).ToArray();

            foreach (var item in sortedNumbers3)
            {
                Console.WriteLine(item);
            }
        }
    }
}
