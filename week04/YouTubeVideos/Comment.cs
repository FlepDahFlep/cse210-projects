public class Comment
{
    public string _Name { get; set; }
    public string _Text { get; set; }

    public Comment(string name, string text)
    {
        _Name = name;
        _Text = text;
    }
}