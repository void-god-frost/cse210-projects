using System;

public class Comment
{
    private string _commenter_name;
    private string _text;

    public Comment(string author, string commentation)
    {
       _commenter_name = author;
       _text = commentation;
    }

    public string GetComment()
    {
        return $"Author: {_commenter_name}: Commented: {_text}";
    }
}