using System.Diagnostics;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathinng Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowy. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        DisplayStartingMessage();
        SetDuration();
        int duration = GetDuration();
        Console.WriteLine($"Get ready...");
        ShowSpinner(1);

        //Condition to loop the program looping for the specified duration
        while (duration >= 10)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);

            Console.Write("Now breathe out... ");
            ShowCountDown(6);


            duration -= 10;
        }
        DisplayEndingMessage();

    }    
}