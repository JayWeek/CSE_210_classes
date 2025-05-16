public class Entry
{
    public string _userQuestion;
    public string _userAnswer;
    public string _dateAsString;

    public Entry(string question, string answer)
    {
        _userQuestion = question;
        _userAnswer = answer;
        _dateAsString = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public void Display()
    {
        Console.WriteLine($"{_dateAsString}: {_userQuestion}: {_userAnswer}");
    }
}
