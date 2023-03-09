using System;
using System.Collections.Generic;
using System.Text;

// Keeps track of the refernece and the text of the scripture
// Can hide words and get the rendered display of the text
// Has the responsibiltity to keep track of the reference, the text, and to 
// hide 

// Responsibilities:
// --Hide Words
// --Get Rendered Text
// --Is Completely Hidden

class Scriptures
{

    // Fields
    private Reference _reference;
    private List<Word> _words;

    // Constructors
    public Scriptures(string referenceText, string text)
    {
        _reference = new Reference(referenceText);
        _words = new List<Word>();

        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }
    }

    public string GetRenderedText()
    {
        var renderedText = _reference.ToString() + "\n";

        foreach (var word in _words)
        {
            renderedText += word.GetRenderedText() + " ";
        }

        return renderedText;
    }

    // Methods\

    public void HideRandomWords()
    {
        var random = new Random();
        var index = random.Next(_words.Count);

        _words[index].Hide();
    }
}