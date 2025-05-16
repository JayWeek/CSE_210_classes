using System;

class Program
{
    static void Main()
    {
        var journal = new Journal();
        var promptGen = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. Display journal entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Search entries"); 
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    string prompt = promptGen.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string answer = Console.ReadLine();
                    var entry = new Entry(prompt, answer);
                    journal.AddEntry(entry);
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    journal.SaveToFile();
                    break;

                case "4":
                    journal.LoadFromFile();
                    break;
                
                case "5":
                    Console.Write("Enter keyword to search: ");
                    string keyword = Console.ReadLine();
                    journal.SearchEntries(keyword);
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }
}
