public class Journal
{
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll() 
    {
        //STILL MAKING SOME CHANGES
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.EntryText}");
            }
        }
        Console.WriteLine("Journal saved to file successfully.");
    }

    public void LoadFromFile(string file)
    {
        using (StreamReader reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
            }
        }
        Console.WriteLine("Journal loaded from file successfully.");
    }
    

}