using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        this.words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                Console.Write("***** ");
            }
            else
            {
                Console.Write(word.GetText() + " ");
            }
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(words.Count);
        words[index].Hide();
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}