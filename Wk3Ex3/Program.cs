using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");

        // Read the input string from the user and convert it to lowercase to handle case insensitivity
        string input = Console.ReadLine().ToLower();

        // "aeiou" contains all vowels, and we check how many characters in 'input' are vowels
        int vowelCount = input.Count(c => "aeiou".Contains(c));

        // Display the total count of vowels in the string
        Console.WriteLine($"The number of vowels in the string is: {vowelCount}");

        Console.ReadLine();
    }
}
