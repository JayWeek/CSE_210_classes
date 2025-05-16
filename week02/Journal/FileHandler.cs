using System;
using System.Collections.Generic;
using System.IO;

public class FileHandler
{
    public void SaveFile(List<Dictionary<string, string>> fileContent)
    {
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var dict in fileContent)
                {
                    string date = dict["Date"];
                    string question = dict["Question"];
                    string answer = dict["Answer"];

                    writer.WriteLine($"{date}, {question}, {answer}");
                }
            }
            Console.WriteLine("File saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the file: {ex.Message}");
        }
    }

    public void LoadFile(List<Dictionary<string, string>> entries)
    {
        Console.Write("Enter file name to load: ");
        string fileName = Console.ReadLine();

        if (!File.Exists(fileName))
        {
            Console.WriteLine("The file does not exist. Please check the name and try again.");
            return;
        }

        try
        {
            entries.Clear();
            foreach (var line in File.ReadLines(fileName))
            {
                var parts = line.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 3)
                {
                    var entryData = new Dictionary<string, string>
                    {
                        { "Date", parts[0].Trim() },
                        { "Question", parts[1].Trim() },
                        { "Answer", parts[2].Trim() }
                    };
                    entries.Add(entryData);
                }
            }
            Console.WriteLine("File loaded successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the file: {ex.Message}");
        }
    }
}
