using System.Threading;

public class Activity
{
    // attributes
    protected string _name = "";
    protected string _description = "";
    private int _duration;

    // constructor
    public Activity()
    {
        _name = "Annoymous";
        _description = "Unknown";
    }


    // getters and setters
    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like the session for? ");
        int setDuration = int.Parse(Console.ReadLine());
        _duration = setDuration;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }


    // Methods of the base
    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(_description);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine($"Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
    }

    //timer and animation spin
    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        int totalMilliseconds = seconds * 1000;
        int delay = 100; // milliseconds per frame
        int elapsed = 0;

        while (elapsed < totalMilliseconds)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(delay);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop); // Erase previous spinner
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
            elapsed += delay;
        }
        Console.WriteLine();

    }

    public void ShowCountDown(int seconds)
    {
        int left = Console.CursorLeft;  // Save current cursor position
        int top = Console.CursorTop;

        for (int i = seconds; i > 0; i--)
        {
            Console.SetCursorPosition(left, top);
            Console.Write($"{i}  "); // Extra space to overwrite previous digit
            Thread.Sleep(1000);
        }

        Console.WriteLine(); // Move to the next line after countdown
    }


}