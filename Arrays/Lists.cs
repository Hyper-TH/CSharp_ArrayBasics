using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Lists
    {
        public static void ShowLists()
        {
            // Unlike arrays which are static in length
            // Lists are dynamic in length

            int[] numbers = new int[3]
            {
                1, 2, 3
            };
            
            List<int> listNumbers = new List<int>();

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("Enter a number: ");
                listNumbers.Add(Convert.ToInt32(Console.ReadLine()));
            }

            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.WriteLine(listNumbers[i]);
            }

            foreach (var item in listNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
