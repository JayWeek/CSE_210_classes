class Video
{
    private string _title;
    private string _author;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();

    //setting up the constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
    }

    //Setup method to create Comment object and append to _videoLength
    public void AddComment(string name, string text)
    {
        Comment _newComment = new Comment(name, text);
        _comments.Add(_newComment);
    }

    //method to return number of comment objects in list
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    //method to display video and comment info
    public void DisplayVideoInfo()
    {
        Console.WriteLine($" Title: {_title}  Creator: {_author}  Video Length: {_videoLength}seconds long.");

        Console.WriteLine("Comment Section:");

        if (_comments.Count <= 0)
        {
            Console.WriteLine("There are no comments");
        }
        else
        {
            foreach (Comment comment in _comments)
            {
                comment.DisplayCommentInfo();
            }
        }
    }

}