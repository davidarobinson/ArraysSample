using System;

namespace ArraysSample
{
    class Program2
    {
        static void Main(string[] args)
        {
            // single dimension
            int[] ages = new int[5] {3, 6, 20, 34, 67};

            Console.WriteLine("Single Dimensional Array");
            foreach (int age in ages)
            {
                Console.WriteLine(string.Format("Item {0}", age));
            }

            Console.Write("\n\nMulti Dimensional Array\n");

            // multi dimensional
            string[,] names = new string[2, 2] { { "Andrew", "Bobby" }, { "Susan", "Peter" } };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.Write("\n\nArray of Arrays\n");

            // Array of arrays
            
            string[][] days = new string[2][] { 
                new string[] { "Monday","Wednesday"}, 
                new string[] { "Tuesday","Friday","Saturday", "Sunday"} 
            };

            foreach (string[] d in days)
            {
                foreach (string day in d)
                {
                    Console.WriteLine(day);
                }
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}