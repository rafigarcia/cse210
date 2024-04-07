class Video 
{

    //Attributes
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    //Constructor

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public int GetNumberComments() {
        return _comments.Count;
    }

    public void AddComment(Comment comment) {
        _comments.Add(comment);
    }
    
    public void DisplayVideo() {
        Console.WriteLine($"Title: {_title} by {_author}");
        Console.WriteLine($"Legth: {_length}");
        Console.WriteLine($"{GetNumberComments()} comments");
        Console.WriteLine();
    }

    public void Displaycomments() {
        foreach (Comment comment in _comments)
        {
           comment.DisplayComment();
        }
    }

}