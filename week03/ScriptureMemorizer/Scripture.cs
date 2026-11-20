using System;
using System.Collections.Generic;

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
         
    }
}