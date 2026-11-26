using System;
using System.Runtime.CompilerServices;

public class Video
{
    private string _title;

    private float _length;

    private List<Comment> _comments;

    public Video(string title, float length)
    {
        _title = title;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(string author, string comments)
    {
        Comment comment = new Comment(author, comments);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        int commentAmount = _comments.Count();
        return commentAmount;    
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} --- Length: {_length}");
    }

    public void DisplayComments()
    {
        foreach (Comment line in _comments)
        {
            Console.WriteLine(line.GetComment());
        }
    }
    public string GetTitleOfVideo()
    {
        return $"{_title}";
    }
}