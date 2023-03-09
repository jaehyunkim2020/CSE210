// Keeps track of the book, chapter, and verse information


// Responsibilities:
// --

class Reference
{
    private string _book;
    private int _chapter;
    private int? _begVerse;
    private int? _endVerse;

    public Reference(string referenceText)
    {
        var parts = referenceText.Split(' ');

        _book = parts[0];
        _chapter = int.Parse(parts[1].Split(':')[0]);

        if (parts[1].Contains("-"))
        {
            var verseParts = parts[1].Split(':')[1].Split('-');
            _begVerse = int.Parse(verseParts[0]);
            _endVerse = int.Parse(verseParts[1]);
        }
        else
        {
            _begVerse = int.Parse(parts[1].Split(':')[1]);
            _endVerse = null;
        }
    }

    public override string ToString()
    {
        var referenceText = _book + " " + _chapter;

        if (_begVerse.HasValue)
        {
            referenceText += ":" + _begVerse.Value;

            if (_endVerse.HasValue)
            {
                referenceText += "-" + _endVerse.Value;
            }
        }

        return referenceText;
    }
}