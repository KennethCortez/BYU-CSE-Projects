public class Video
{
    public string _title;
    public string _author;
    public int _durationInSeconds;
    public List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int durationInSeconds)
    {
        _title = title;
        _author = author;
        _durationInSeconds = durationInSeconds;
    }

    public void AddComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        _comments.Add(newComment);
    }
    public void ShowInfoVideo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (Seconds): {_durationInSeconds}");
        Console.WriteLine("Number of comments; " + _comments.Count);
        Console.WriteLine("Comments");
        foreach (Comment newComment in _comments)
        {
            newComment.ShowComment();
        }
    }
}