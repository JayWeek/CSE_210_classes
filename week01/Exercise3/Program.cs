using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Boolean running = true;
        string continuePlaying ;
        int guessCount = 0;

        do
        {
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1,100);
            // Console.WriteLine($"The magic number is {magicNumber}");
            do
        {
            Console.Write("Can you guess the number? ");
            string guessString = Console.ReadLine();
            int guess = int.Parse(guessString);
            if (guess < magicNumber)
            {
                Console.WriteLine("Guess higher!");
                guessCount ++;
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Guess lower!");
                guessCount ++;
            }
            else
            {
                Console.WriteLine("Congratulations. You guessed the number.");
                running = false;
            }
            }while (running);

            Console.WriteLine($"It took you {guessCount} trials to guess the right number.");

            Console.Write("Do you want to continue? ");
            continuePlaying = Console.ReadLine();

        }while (continuePlaying == "yes");
        
        

    }
}