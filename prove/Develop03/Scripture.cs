using System;

public class Scripture
{
    Reference _reference;
    List<Word> _words;

    public Scripture(Reference Reference, string text)
    {
        _reference = Reference;
        // _words = text;
    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        string text = $"{_reference} - {_words}";
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}