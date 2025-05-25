public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    //Setting up the constructor to allow two parameters when initiated.

    public Scripture(string referenceString, string sentence)
    {
        //Splitting the reference text "John 3:16-17"
        string[] parts = referenceString.Split(' '); //["John", "3:16-17"]
        string book = parts[0]; // "John"
        string[] chapterAndVerse = parts[1].Split(':'); // ["3", "16-17"]
        int chapter = int.Parse(chapterAndVerse[0]); // 3
        string[] verseParts = chapterAndVerse[1].Split('-'); //["16", "17"] or just ["16"] if endverse is not added.
        int verse = int.Parse(verseParts[0]); // 16

        if (verseParts.Length == 2)
        {
            int endVerse = int.Parse(verseParts[1]); // 17

            //initiating the object 
            _reference = new Reference(book, chapter, verse, endVerse);
        }
        else
        {
            _reference = new Reference(book, chapter, verse);
        }

        //Splitting the sentence, "For God so Loved the world" into word objects
        string[] wordParts = sentence.Split(" "); // ["For", "God", "so", "Loved", "the", "world"]

        //first initialize the list
        _words = new List<Word>();

        //Loop through each word and turn that word into an object of Word
        foreach (string word in wordParts)
        {
            // "For" will be turned into Word object
            Word wordObj = new Word(word);

            _words.Add(wordObj);// The object "For" is added to the object list
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> visibleWords = _words.Where(w => !w.IsHidden()).ToList();

            if (visibleWords.Count == 0)
            {
                break; // nothing left to hide. All the words are already hidden.
            }

            int index = rnd.Next(visibleWords.Count); // picks a random index
            visibleWords[index].Hide(); // hides the word

        }
    }

    public string GetDisplayText()
    {
        string display = "";

        foreach (Word word in _words)
        {
            display += word.GetDisplay() + " ";
        }
        
        string referenceText = _reference.GetDisplayText();

        return $"{referenceText} - {display.TrimEnd()}"; // remove trailling space
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

