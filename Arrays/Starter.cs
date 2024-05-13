using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Starter
    {
        public static void ShowArrays()
        {
            // Part I 

            // Instantiate with new
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            // Will go for every single position
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Part II
            const int angleCount = 3;
            int[] angles = new int[angleCount];
            int angleSum = 0;

            for (int i = 0; i < angles.Length; i++)
            {
                Console.WriteLine($"Enter angle: {i + 1}");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach(int num in angles)
            {
                angleSum += num;
            }

            Console.WriteLine($"Total angle: {angleSum}");

            // Alternative Part III
            const int count = 3;
            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter num: ");
                sum += Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
