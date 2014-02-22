using System;

namespace ArraysSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // single dimension
            int[] ages = new int[5];
            ages[0] = 3;
            ages[1] = 6;
            ages[2] = 20;
            ages[3] = 34;
            ages[4] = 67;
            
            Console.WriteLine("Single Dimensional Array");
            for (int ageLoop = 0; ageLoop < ages.Length; ageLoop++)
            {
                Console.WriteLine(string.Format("Item {0}: {1}", ageLoop, ages[ageLoop]));
            }

            Console.Write("\n\nMulti Dimensional Array\n");

            // multi dimensional
            string[,] names = new string[2, 2];
            names[0, 0] = "Andrew";
            names[0, 1] = "Bobby";
            names[1, 0] = "Susan";
            names[1, 1] = "Peter";

            Console.WriteLine("Row\tCol\tValue");
            for (int row = 0; row < names.GetLength(0); row++)
            {
                for (int col = 0; col < names.GetLength(row); col++)
                {
                    Console.WriteLine(String.Format("{0}\t{1}\t{2}", row, col, names[row, col]));
                }
            }

            Console.Write("\n\nArray of Arrays\n");

            // Array of arrays
            string[][] days = new string[2][];

            days[0] = new string[2];
            days[0][0] = "Monday";
            days[0][1] = "Wednesday";

            days[1] = new string[4];
            days[1][0] = "Tuesday";
            days[1][1] = "Friday";
            days[1][2] = "Saturday";
            days[1][3] = "Sunday";

            Console.WriteLine("Row\tCol\tValue");
            for (int row = 0; row < days.GetLength(0); row++)
            {
                for (int col = 0; col < days[row].GetLength(0); col++)
                {
                    Console.WriteLine(String.Format("{0}\t{1}\t{2}", row, col, days[row][col]));
                }
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
/*
In the above exmaples the array elements have been set long hand, an element at a time.  It is possible to initialise
an array at the same time as the declaration.

// single dimension array
int[] ages = new int[4] = {1, 2, 3, 4};
string[] names = new string[4] = {"Andrew", "Bobby", "Susan", "Peter"};
     
// multi dimension array
int[,] numbers = new int{1, 9] { {2, 8}, {3, 7}, {4, 6}, {5, 5} };
string[,] siblings = new string[2, 2] { {"Mike","Amy"}, {"Mary","Albert"} };

// array of Arrays
int[][] days = new int[2][] { new int[] {1, 2, 3}, new int[] {98, 99, 100} };

Instead of using a for loop to iterate an arry a foreach loop can be used.  This is not as useful on multi dimension arrays
because the whole array is treated as one single list.

// single dimension array
foreach (int age in ages)
{
    Console.WriteLine(string.Format("Item {0}", age));
}

// multi dimension array
foreach (string name in names)
{
    Console.WriteLine(name);
}

// array of arrays
foreach (string[] d in days)
{
    foreach (string day in d)
    {
        Console.WriteLine(day);
    }
}

Array Lengths
You will notice in the top example the single dimensional array example uses the Length property to get the length of the array. 
In the other examples the GetLength method has been used.  The Length property will give the total number of elements in an array 
which is 5 in the ages array and 4 in the names array.
The GetLength method accepts an array index (integer) and will return the length of the particular element which in the days array
is 2 for the first element and 4 for the second.

ages.Length //5 - Full length of array
ages.GetLength(0) //5 - single dimension so full length of array
ages.GetUpperBound(0) //4 - Index range is 0 to 4
names.Length // 4 - Full length of array
names.GetLength(0) // 2 - Length of elements in first dimension	
names.GetUpperBound(0)// 1 - first dimensions index range is 0 to 1
days.Length // 2 - Length of main array	2
days.GetLength(0) // 2 - Length of array in first element	
days.GetUpperBound(0) // 1 - Array index range is 0 to 1	
days[0].GetUpperBound(0) // 1 - First element array index range is 0 to 1
days[1].GetUpperBound(0) // 3 - Second element array index range is 0 to 3	
days[1].Length // 4 - Length of array in First element	
days[1].GetUpperBound(0) // 3 - Second element array index range is 0 to 3

*/

