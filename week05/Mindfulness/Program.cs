// ADDED FUNCTIONALITY TO PREVENT DUPLICATE QUESTIONS FROM BEING PICKED FOR QUESTIONS IN THE REFLECTING ACTIVITY
// ADDED FUNCTIONALITY TO REVIEW THE PROMPT AND USERS RESPONSES IN LISTINGACTIVITY
using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");

        while (true)
        {
            Console.WriteLine("\nMenu options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.Run();
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                    break;

                case "3":
                    ListingActivity list = new ListingActivity();
                    list.Run();
                    break;

                case "4":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }
}
