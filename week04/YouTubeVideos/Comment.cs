class Comment
{
    private string _name;
    private string _CommentText;

    //creating constructor to initiate state
    public Comment(string name, string text)
    {
        _name = name;
        _CommentText = text;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_name}: {_CommentText}");
    }
    
}