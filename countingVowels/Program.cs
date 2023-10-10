using System;
using System.Collections.Generic;

namespace countingvowels
{
    public class MainClass
    {
        public static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            { 'a', 1 },
            { 'e', 2 },
            { 'i', 3 },
            { 'o', 4 },
            { 'u', 5 },
            { 'y', 9 }
        };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Type in a word or phrase to find it's vowel score:");
            string input = Console.ReadLine();

            if (input != null)
            {
                 // MARK: Result
                            Console.WriteLine($"Your input vowel score is {VowelCount(input)}.");
                            Console.ReadKey();
            }
            else
            {
                throw new NullReferenceException("You typed nothing");
            }

           
        }

        // MARK: Write your solution here
        public static int VowelCount(string text)
        {
            int totalScore = 0;
            foreach (char letter in text)
            {
                if (vowelScores.TryGetValue(letter, out int value))
                {
                    totalScore += value;
                }
            }

            return totalScore;
        }
    }
}