using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        // Create activity objects
        RunningActivity running = new RunningActivity("03 Nov 2022", 30, 4.8);       // 4.8 km in 30 min
        CyclingActivity cycling = new CyclingActivity("03 Nov 2022", 45, 20.0);       // 20 kph for 45 min
        SwimmingActivity swimming = new SwimmingActivity("03 Nov 2022", 30, 40);      // 40 laps in 30 min

        // Adding objects to list
        List<Activity> activities = new List<Activity>
        {
            running,
            cycling,
            swimming
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}