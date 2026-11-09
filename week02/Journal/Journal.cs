using System;
using System.Runtime.CompilerServices;
using System.IO;

public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry currentEntry in _entries)
            {
                outputFile.WriteLine($"{currentEntry._date}|{currentEntry._promptText}|{currentEntry._entryText}");
            }  
        }
    }

    public void LoadFromFile(string file)
    {
      string[] entryLines = System.IO.File.ReadAllLines(file);
      _entries.Clear();

      foreach (string entryLine in entryLines)
        {
            if (string.IsNullOrWhiteSpace(entryLine))
            {
                continue;
            }

            string[] entryParts = entryLine.Split('|');

           if (entryParts.Length >= 3)
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = entryParts[0];
                loadedEntry._promptText = entryParts[1];
                loadedEntry._entryText = entryParts[2];

                _entries.Add(loadedEntry);
                loadedEntry.Display();
            }
        }  
        Console.WriteLine($"Successfully loaded {_entries.Count}");
    }

    


}
