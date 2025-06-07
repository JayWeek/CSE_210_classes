public class ListingActivity : Activity
{
    private int _count;
    private string _currentPrompt = "";
    private List<string> _responses = new List<string>();

    private List<string> _prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // Constructor
    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    // Display the prompts
    private void DisplayPrompt()
    {
        _currentPrompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"-- {_currentPrompt} --\n");
    }

    // Generate prompts at random
    private string GetRandom(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return list[index];
    }

    private string GetRandomPrompt()
    {
        return GetRandom(_prompts);
    }

    // Run
    public void Run()
    {
        _responses.Clear(); // Clear previous responses
        _count = 0;

        // Initial startup message
        DisplayStartingMessage();
        SetDuration();
        int duration = GetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner(1);

        // Special class methods
        DisplayPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                _responses.Add(userInput);
                _count++;
            }
        }

        if (_count <= 0)
        {
            Console.WriteLine("You did not list anything.");
        }
        else
        {
            Console.WriteLine($"You listed {_count} item(s).");
        }

        // Ask if user wants to review answers
        Console.Write("\nWould you like to review your responses? (y/n): ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y")
        {
            Console.WriteLine("\n--- Prompt ---");
            Console.WriteLine(_currentPrompt);
            Console.WriteLine("\n--- Your Responses ---");
            foreach (var response in _responses)
            {
                Console.WriteLine($"- {response}");
            }
        }

        Console.WriteLine();
        DisplayEndingMessage();
    }
}
