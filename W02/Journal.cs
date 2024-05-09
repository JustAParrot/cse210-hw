using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

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
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    //Added this part to save it to a CSV file 

    public void SaveToCsv(string filename)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine("Date,Prompt,Response");

                foreach (var entry in _entries)
                {
                    writer.WriteLine($"\"{entry.Date}\",\"{Escape(entry.PromptText)}\",\"{Escape(entry.EntryText)}\"");
                }
            }

            Console.WriteLine($"Journal saved to {filename} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }

    public void LoadFromCsv(string filename)
    {
        _entries.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string date = parts[0].Trim('"');
                    string prompt = parts[1].Trim('"');
                    string response = parts[2].Trim('"');
                    _entries.Add(new Entry(date, prompt, response));
                }
            }

            Console.WriteLine($"Journal loaded from {filename} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading the journal: {ex.Message}");
        }
    }

    private string Escape(string input)
    {
        return input.Replace("\"", "\"\"");
    }
}
