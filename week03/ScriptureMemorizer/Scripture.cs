using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] texts = text.Split(' ');

        foreach (string words in texts)
        {
            Word newWord = new Word(words);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rng = new Random();
        int hidden = 0;

        while (hidden < numberToHide && !IsCompletelyHidden())
        {
            int idx = rng.Next(_words.Count);

            if (!_words[idx].IsHidden())
            {
                _words[idx].Hide();
                hidden++;
            }
        }
    }

    public string GetDisplayText()
    {
        string output = _reference.GetDisplayText();

        foreach(Word word in _words)
        {
            output += " " + word.GetDisplayText();
        }
        return output;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}