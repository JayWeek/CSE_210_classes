class Word
{
    private string _text;
    private Boolean _isHidden;

    //Setting up the constructor. The text is visible by default.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    //Methods
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplay()
    {
        if (_isHidden)
        {
            string underscores = "";
            foreach (char letter in _text)
            {
                if (char.IsLetter(letter))
                {
                    underscores += "_";
                }
                else
                {
                    underscores += letter;
                }
            }
            return underscores;
        }
        else
        {
            return _text;
        }
    }
    

}