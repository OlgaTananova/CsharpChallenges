using System;
using System.Collections.Generic;
using System.Timers;

namespace affirmingwords
{
    class MainClass
    {
        private static System.Timers.Timer timer;
        static Random random = new Random();

        static List<string> encouragements = new List<string>()
        {
            "Way to go!",
            "Keep it up!",
            "Almost there!",
            "You're doing great!"
        };

        private static void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            int randomEncouragement = random.Next(1, encouragements.Count);

            Console.WriteLine(encouragements[randomEncouragement]);
        }

        public static void Main(string[] args)
        {
            // MARK: Setup

            Console.WriteLine("Hit ENTER to start the timer!");
            Console.ReadLine();

            // MARK: Result
            StartTimer(3000);

            Console.WriteLine("You can end the timer anytime by pressing ENTER.\n");
            Console.ReadLine();
            StopTimer();
        }

        // MARK: Write your solution here...
        public static void StartTimer(int interval)
        {
            timer = new System.Timers.Timer(interval);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }


        // 6
        public static void StopTimer()
        {
            timer.Stop();
            timer.Dispose();
        }
    }
};