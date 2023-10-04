using System;

namespace voting
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("How old are you?");
            bool isValidInput = int.TryParse(Console.ReadLine(), out int age);

            if (isValidInput) {
                var presidents = CalculatePresidents(age);
                Console.WriteLine($"You've voted for {presidents} presidents!");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("You typed incorrect age.");
            }
        }

        // MARK: Write your solution here
        public static int CalculatePresidents(int age)
        {
            int result = 0;
            
            if (age <= 18)
            {
                Console.WriteLine("You are not eligible to vote.");
                return result;
            }
            result = (age - 18) / 4;
            return result;
        }
    }
}