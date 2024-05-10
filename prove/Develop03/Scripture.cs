using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
{
    var random = new Random();
    var wordsToHide = Math.Min(numberToHide, _words.Count(word => !word.IsHidden()));

    foreach (var word in _words.Where(word => !word.IsHidden()).OrderBy(_ => random.Next()).Take(wordsToHide))
    {
        word.Hide();
    }
}

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n\n{_words.Select(word => word.GetDisplayText()).Aggregate((x, y) => $"{x} {y}")}";
    }

    public bool IsCompletelyHidden()
{
    return _words.All(word => word.IsHidden());
}
}