using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new();
    }

    public int CountComments()
    {
        return _comments.Count();
    }
    public void DisplayComments()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine(c.GetRenderedComment());
        }
    }
}