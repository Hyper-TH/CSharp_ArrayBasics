using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    public static class Dictionaries
    {
        public static void ShowDictionary()
        {
            Dictionary<int, string> names = new Dictionary<int, string>
            {
                // Key value pair
                { 1, "Hyper" },
                { 2, "Max" },
                { 3, "GB" }
            };

            // names.Add(1, "Hyper");
            // names.Add(2, "Max");
            // names.Add(3, "GB");

            for (int i =  0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} : {pair.Value}");

                // names.ElementAt(i);
            }

            Console.WriteLine("");

            foreach (KeyValuePair<int, string> pair in names)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                { "Math", "Twila" },
                { "Science", "Hyper" }
            };

            // Console.WriteLine(teachers["Math"]);

            // Try get the value for Math
            if (teachers.TryGetValue("Math", out string teacher))
            {
                Console.WriteLine(teacher);

                teachers["Math"] = "Joe";
            }
            else
            {
                Console.WriteLine("Math teacher not found");
            }


            if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }

            foreach (KeyValuePair<string, string> pair in teachers)
            {
                Console.WriteLine($"{pair.Key} : {pair.Value}");
            }
        }
    }
}
