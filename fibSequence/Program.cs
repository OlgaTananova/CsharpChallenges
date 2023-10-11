using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace fibsequence
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // MARK: Setup
            Console.WriteLine("Enter the number of Fibonacci elements you'd like to calculate:");
            int input = int.Parse(Console.ReadLine());

            // MARK: Result
            var sequence = CalculateFibRecursion(input);
            foreach (var fibonacci in sequence)
            {
                Console.WriteLine(fibonacci);
                
            }
            Console.ReadKey();
        }

        // MARK: Write your solution here
        public static List<int> CalculateFibonacci(int length)
        {
            List<int> sequence = new List<int>();
            int firstMember = 0;
            int secondMember = 1;
            sequence.Add(firstMember);
            sequence.Add(secondMember);
            for (int i = 2; i < length; i++)
            {
                int nextMember = firstMember + secondMember;
                sequence.Add(nextMember);
                firstMember = secondMember;
                secondMember = nextMember;
            }
            
            return sequence;
        }

        public static List<int> CalculateFibRecursion(int length)
        {
            List<int> sequence = new List<int>();
            int firstMember = 0;
            int secondMember = 1;
            sequence.Add(firstMember);
            sequence.Add(secondMember);

            void Hepler(int a, int b, List<int> array)
            {
                if (array.Count == length) return;
                int nextMember = a + b;
                array.Add(nextMember);
                Hepler(b, nextMember, array );
            }
            Hepler(firstMember, secondMember, sequence);
            return sequence;
            
        }
    }
}