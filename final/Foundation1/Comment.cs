class Comment 
{
    //Attributes
    private string _user;
    private string _comment;

    //Constructor
    public Comment (string user, string comment)
    {
        _user = user;
        _comment = comment;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"Comment by {_user}: {_comment}");
        Console.WriteLine();
    }




}