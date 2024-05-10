//Basically this whole class is the "Exceeding Requirements"
using System;
using System.Collections.Generic;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
    }

    public void AddScripture(Scripture scripture)
    {
        _scriptures.Add(scripture);
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            Console.WriteLine("Scripture library is empty.");
            return null;
        }

        int randomIndex = _random.Next(0, _scriptures.Count);
        return _scriptures[randomIndex];
    }
}