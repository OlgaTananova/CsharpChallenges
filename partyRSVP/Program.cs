using System;
using System.Collections.Generic;

namespace partyrsvp
{
    class MainClass
    {
        static List<string> family = new List<string>() { "Harrison", "Kelsey", "Alex", "Haley" };
        static List<string> friends = new List<string>() { "James", "Hannah", "Kelly", "Alex" };
        static List<string> rsvp = new List<string>() { "Kelly", "Harrison" };

        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Hit ENTER to see your party invite breakdown!");
            Console.ReadKey();

            // MARK: Result
            InviteDetails();
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void InviteDetails()
        {

            List<string> combinedList = family.Concat(friends).ToList();
            List<string> distinctGuests = combinedList.Distinct().ToList();
            string [] missingGuests = (from g in distinctGuests
                where !rsvp.Contains(g)
                select g).ToArray();
            Console.WriteLine($"The total invites are {distinctGuests.Count}");
            Console.WriteLine($"The count of duplicates is {combinedList.Count - distinctGuests.Count}");
            Console.WriteLine($"The missing guests are {(string.Join(',', missingGuests))}");
        }

    }
}