using System;
using System.Configuration.Assemblies;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Transactions;

public class Video
{
    private string _clipTitle;
    private string _clipAuthor;
    private int _clipLength;
    private List<Comment> _peanuts = new List<Comment>();

    public Video(string clipTitle, string clipAuthor, int clipLength)
    {
        _clipTitle= clipTitle;
        _clipAuthor= clipAuthor;
        _clipLength= clipLength;
    }

    public void AddComment(string commentorName, string comment)
    {
        Comment c1 = new Comment(commentorName, comment);
        _peanuts.Add (c1);

    }


    public void DisplayVideo()
    {
        //string peanutCount;
        Console.WriteLine();
        Console.WriteLine($"Video Title: {_clipTitle}");
        Console.WriteLine($"Video Author: {_clipAuthor}");
        Console.WriteLine($"Video length: {_clipLength}");
        Console.WriteLine();
 
        int commentCount=0;
        foreach (Comment peanut in _peanuts)
        {
            if (commentCount == 0)
            {
                Console.WriteLine($"This video has {_peanuts.Count} comments:");
            }
            commentCount++;
            Console.WriteLine($"{peanut.DisplayComments()} ");
        }
    }

}


