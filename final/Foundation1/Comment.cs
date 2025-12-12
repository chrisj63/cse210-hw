using System;
using System.Reflection.Metadata;

public class Comment
{
    // This is the Comment class and handles creating and displaying Comment objects.
    //Each Comment object has a Commnetor name and a comment associated with it.
    private string _commentorName;
    private string _comment;

    public Comment(string commentorName, string comment)
    {
        _commentorName = commentorName;
        _comment = comment;
    }

    public string DisplayComments()
    {
        string tempText = " " + _commentorName + " : " + _comment + " ";
        return tempText;
    }
}