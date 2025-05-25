using System;
using System.Collections.Generic; // <-- Added to use List
using System.IO; // <-- Added to read from a file

class Program
{
    static void Main(string[] args)
    {
        // --- Added: Load scriptures from file ---
        string reference = "";
        string text = "";

        string filePath = "scripture.txt";
        List<(string reference, string text)> scriptures = new List<(string, string)>();

        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (line.Contains("|"))
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 2)
                    {
                        scriptures.Add((parts[0].Trim(), parts[1].Trim()));
                    }
                }
            }

            // Pick one at random
            Random rand = new Random();
            var selected = scriptures[rand.Next(scriptures.Count)];
            reference = selected.reference;
            text = selected.text;
        }
        else
        {
            Console.WriteLine("File 'scriptures.txt' not found.");
            return;
        }
        // --- End of additions ---

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                Console.ReadKey();
                break;
            }

            scripture.HideRandomWords(3); // Adjust number of words to hide per loop
        }
    }
}
