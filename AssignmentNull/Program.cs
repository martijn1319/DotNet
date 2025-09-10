using System;

namespace AssignmentNull {
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a sentence: ");
            string input = Console.ReadLine();

            // Split on spaces, remove empty entries 
            string[] words = input.Split(
                new char[] { ' ', '\t' }, 
                StringSplitOptions.RemoveEmptyEntries
            );

            Console.WriteLine($"You entered {words.Length} words.");
        }
    }
}