public class Entry
{
    public string _date { get; }
    public string _promptText { get; }
    public string _entryText { get; }

    public Entry(string date, string prompt, string entryText)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Entry: {EntryText}\n");
    }
}
//STILL MAKING SOME CHANGES