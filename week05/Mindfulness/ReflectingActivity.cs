public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Recall a moment when you overcame a challenge.",
        "Remember a time you made someone smile.",
        "Think about a time you learned something new about yourself.",
        "Recall a moment you felt truly at peace.",
        "Think of a time when you helped someone without expecting anything back.",
        "Remember a moment you felt proud of yourself.",
        "Think about a time when you stayed calm under pressure."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "What did you learn about yourself from this?",
        "How did this make you feel at the time?",
        "What could you take away from this experience?",
        "Would you handle it differently today? Why or why not?",
        "How did this affect the people around you?",
        "What strengths did you use in that moment?",
        "What emotions did you experience during and after?"
    };

    private List<string> _usedQuestions = new List<string>();

    // Constructor
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life";
    }

    // Generate random item from list
    private string GetRandom(List<string> list)
    {
        Random rand = new Random();
        int index = rand.Next(list.Count);
        return list[index];
    }

    private string GetRandomPrompt()
    {
        string prompt = $"{GetRandom(_prompts)} ";
        return prompt;
    }

    private string GetRandomQuestions()
    {
        // Reset if all questions have been used
        if (_usedQuestions.Count == _questions.Count)
        {
            _usedQuestions.Clear();
        }

        // Get only unused questions
        List<string> unusedQuestions = _questions.Except(_usedQuestions).ToList();

        Random rand = new Random();
        int index = rand.Next(unusedQuestions.Count);
        string selected = unusedQuestions[index];

        _usedQuestions.Add(selected);
        return selected;
    }

    // Display methods
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"-- {GetRandomPrompt()} --\n");
    }

    private void DisplayQuestions()
    {
        Console.WriteLine($"> {GetRandomQuestions()}");
    }

    // Run method
    public void Run()
    {
        // Initial startup message
        DisplayStartingMessage();
        SetDuration();
        int duration = GetDuration();
        Console.WriteLine($"Get ready...");
        ShowSpinner(1);

        // Special class methods
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on the following questions");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        while (duration >= 10)
        {
            DisplayQuestions();
            ShowSpinner(10);
            duration -= 10;
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }
}
