class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // Setting up constructors for when endverse is not or when its included
    public Reference(string book, int chapter, int verse) // This doesn't need the endverse parameter passed in. Defaults to 0
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;

    }

    public Reference(string book, int chapter, int verse, int verseEnd) // This needs the endverse parameter passed in. 
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verseEnd;
    }

    public string GetDisplayText() //Method aka function to display the member variables as string
    {
        if (_endVerse != 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }

        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}
