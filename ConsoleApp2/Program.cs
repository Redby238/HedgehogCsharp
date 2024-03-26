using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialPopulation = { 8, 1, 9 }; // 8 red, 1 green, 9 blue(how it was said in the conditions)
            int targetColor = 1; // 0: red, 1: green, 2: blue(indexers)

            int[][] colorChanges = {
                new int[] { 0, 2, 1 }, 
                new int[] { 1, 0, 2 }, 
                new int[] { 2, 1, 0 }  
            };
            /*
            ^
            |
            the colorChanges array is doing different combinations of colors
             
             */
            int days = 0;
            while (true)
            {
                bool changed = false;
                for (int i = 0; i < initialPopulation.Length; i++) //The outer loop goes through each colorHedgehogs we have  in the population.
                {
                    for (int j = 0; j < colorChanges.Length; j++) // The inner loop checks each color change rule.
                    {
                        if (initialPopulation[colorChanges[j][0]] > 0 &&
                            initialPopulation[colorChanges[j][1]] > 0 &&
                            initialPopulation[colorChanges[j][2]] < int.MaxValue)
                        {
                            initialPopulation[colorChanges[j][2]]++;
                            initialPopulation[colorChanges[j][0]]--;
                            initialPopulation[colorChanges[j][1]]--;
                            changed = true;
                        }
                    } /* The if statements ensures there's at least one hedgehog of the "source" color/
                       Ensures there's at least one hedgehog of the other "source" color/
                        and the < int.MaxValue is checking if population isn't max integer val
                       */
                }
                if (!changed)
                {
                    break;
                }
                days++;
            }

            Console.WriteLine("Days to reach target color: " + days);
            Console.ReadLine();
        }
    }
}