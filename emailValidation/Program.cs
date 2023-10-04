using System;

namespace validatingemails
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the email address you'd like to validate:");
            var input = Console.ReadLine();

            // MARK: Result
            ValidateEmail(input);
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static void ValidateEmail(string email)
        {
            if (email == "")
            {
                Console.WriteLine("You did not type anything.");
                    return;
            }
            char firstChar = email[0];

            if (!char.IsLetter(firstChar))
            {
                Console.WriteLine("Your email is not valid, it must not start with a symbol or a number.");
                
            } else if (!email.Contains('@'))
            {
                Console.WriteLine("Your email must contain '@' sign.");
                
            } else if (!email.EndsWith(".com"))
            {
                Console.WriteLine("Your must end with '.com'.");
            }
            else
            {
                Console.WriteLine("You entered valid email.");
            }
        }
    }
}