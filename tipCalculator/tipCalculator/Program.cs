using System;
using System.Reflection;

namespace tipcalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the cost of your meal to calculate tip options:");
            var input = Console.ReadLine();
            bool isValidInput = int.TryParse(input, out int amount);

            // MARK: Result 
            // MARK: Result 
            if (isValidInput )
            {
                    CalculateTip(amount);
                    Console.ReadKey();
            } else
            {
                Console.WriteLine("Not valid input!");
            }
           
        }

        // MARK: Write your solution here
        public static void CalculateTip(int cost)
        {
            double tip1 = cost * 0.1;
            double tip2 = cost * 0.175;
            double tip3 = cost * 0.25;
            (double, double, double) tips = (tip1, tip2, tip3);
            Console.WriteLine($"10% -> {tips.Item1:$0.00}\n17.5% -> {tips.Item2:$0.00}\n25% -> {tips.Item3:$0.00}");
        }
    }
}
