using System;
using System.Collections.Generic;

namespace shufflingcards
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to shuffle the deck and deal the top 5 cards!");
            Console.ReadKey();

            // MARK: Result
            var freshDeck = new Deck();

            var shuffledDeck = Shuffle(freshDeck.cards);

            foreach (var item in shuffledDeck)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        // MARK: Write your solution here...
        public static List<string> Shuffle(List<string> deck)
        {
            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(0, n + 1);
                string value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
            return deck;
        }
    }
}