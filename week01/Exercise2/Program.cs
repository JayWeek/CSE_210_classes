using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("Enter your percentage grade: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if(grade >= 70)
        {
            letter = "C";
        }
        else if(grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }


        if (!(letter == "A" || letter == "F"))
        {
            int remainder = grade % 10;
            if (remainder >= 7)
            {
                sign = "+";
            }
            else if (remainder <= 3)
            {
                sign = "-";
            }
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        if (letter == "D" || letter == "F")
        {
            Console.WriteLine("You've failed. You can do this. Keep trying.");
        }
        else
        {
            Console.WriteLine("congratulations. You've passed.");
        }

    }
}