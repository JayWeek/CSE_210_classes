using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private FileHandler _fileHandler = new FileHandler();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        // Prepare data to save as List of dictionaries
        List<Dictionary<string, string>> fileContent = new List<Dictionary<string, string>>();

        foreach (var entry in _entries)
        {
            var entryData = new Dictionary<string, string>
            {
                {"Date", entry._dateAsString},
                {"Question", entry._userQuestion},
                {"Answer", entry._userAnswer}
            };
            fileContent.Add(entryData);
        }

        _fileHandler.SaveFile(fileContent);
    }

    public void LoadFromFile()
    {
        var loadedEntries = new List<Dictionary<string, string>>();
        _fileHandler.LoadFile(loadedEntries);

        _entries.Clear();

        foreach (var dict in loadedEntries)
        {
            var entry = new Entry(dict["Question"], dict["Answer"])
            {
                _dateAsString = dict["Date"]
            };
            _entries.Add(entry);
        }
    }

    public void SearchEntries(string keyword)
    {
        bool found = false;
        foreach (var entry in _entries)
        {
            if ((entry._userQuestion != null && entry._userQuestion.Contains(keyword, StringComparison.OrdinalIgnoreCase)) ||
                (entry._userAnswer != null && entry._userAnswer.Contains(keyword, StringComparison.OrdinalIgnoreCase)))
            {
                entry.Display();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No entries found matching your search.");
        }
    }


    

}
