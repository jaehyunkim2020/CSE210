// Keeps track of a single word and whether it is shown or hidden
// Stores the text of a word and whether it is hidden or not


// Responsibilities:
// --Hide
// --Show
// --Is Hidden
// --Get Rendered Text

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public string GetRenderedText()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }



}