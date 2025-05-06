using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbersList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type  0 when finished");

        int numbers;

        do
        {
            Console.Write("Enter number: ");
            string numbersString = Console.ReadLine();
            numbers = int.Parse(numbersString);
            
            numbersList.Add(numbers);

            if (numbers == 0)
            {
                numbersList.RemoveAt(numbersList.Count -1);
            }

        }while (!(numbers == 0));

        //Console.WriteLine(string.Join(", ", numbersList));  

        int sum = numbersList.Sum();
        Console.WriteLine($"The sum is: {sum}");

        if (numbersList.Count > 0)
        {
            double Average = numbersList.Average();
            Console.WriteLine($"The average is: {Average}");
        }
        else
        {
            Console.WriteLine("The list is empty");
        }

        int largest = 0;

         for (int i = 0; i < numbersList.Count; i ++)
         {
            
            if (numbersList[i] > largest)
            {
                largest = numbersList[i];
            }
         }

         Console.WriteLine($"The largest number is: {largest}");

    }
}   