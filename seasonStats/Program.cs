using System;
using System.Collections.Generic;
using System.Linq;

namespace seasonstats
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            List<int> scores = new List<int>();

            for(int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse(Console.ReadLine());
                scores.Add(input);
            }

            // MARK: Result
            PrintStats(scores);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void PrintStats(List<int> scores)
        {
            scores.Sort();
            int lowestScore = scores[0];
            int highestScore = scores[scores.Count - 1];
            int sum = 0;
            for (int i = 0; i < scores.Count; i++)
            {
                sum += scores[i];
            }
            int average = sum / scores.Count;
            // Using LINQ syntax
            // int highestScore = scores.Max();
            // int lowestScore = scores.Min();
            // int sum = scores.Sum();
            // double average = scores.Average();
            Console.WriteLine($"Highest score is {highestScore}, the lowest score is {lowestScore}, the total score is {sum}, the average score is {average:N}.");
        }
    }
}