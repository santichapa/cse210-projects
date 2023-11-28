using System.Text.Encodings.Web;

class Comment
{
    private string _user;
    private string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public string GetRenderedComment()
    {
        return $"\n[{_user}]:\n\t{_text}";
    }
}