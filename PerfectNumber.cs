/**
 *  Author:      Nicholas Martin
 *  Date:        12/10/2019
 *  Description: Calculates perfect squares up to a max number.   
 **/

using System.Collections.Generic;
using static System.Console;

namespace Perfect
{
    class Program
    {
        static void Main()
        {
            WriteLine("Seeks for perfect numbers");
            List<int> perfNums = new List<int>();   // List that holds perfect numbers
            Write("Max range: ");
            int max = int.Parse(ReadLine());    // Max number to search up to.
            CalcPerfect(max, ref perfNums);

            // Prints results
            WriteLine($"\nPerfect numbers: ");
            foreach (int var in perfNums)
            {
                Write($"{var} ");
            }
            ReadKey();
        }

        // Calculates perfect squares
        // Pre-condition:  0 < max < infinity
        // Post-condition: Displays perfect numbers up to max int
        static void PerfNums(int max, ref List<int> perfNums)
        {
            for (int i = 1; i <= max; i++)
            {
                WriteLine($"i:{i}");
                int y = 0;  // 
                for (int x = 1; x < i; x++)
                {
                    if (i % x == 0)
                    {
                        WriteLine($"\tx:{x}");
                        y += x;
                    }
                }
                if (y == i)
                {
                    WriteLine($"Perfect Number: {i}");
                    perfNums.Add(i);
                }
                WriteLine();
            }
        }
    }
}