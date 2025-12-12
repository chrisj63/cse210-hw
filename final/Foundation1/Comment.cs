using System;
using System.Reflection.Metadata;

public class Comment
{

    private string _commentorName;
    private string _comment;
    //List<Comment> _comments = new List<Comment>();

   
    public Comment(string commentorName, string comment)
    {
        _commentorName=commentorName;
        _comment=comment;
    }
   
   
    public string DisplayComments()
    {
             string tempText = " " + _commentorName  + " : " + _comment + " ";
             return tempText;
    }

   /* private int CountComments()
    {
      int numberOfComments = 0;

      foreach (string comment in _comments)
        {
            numberOfComments++;    
        }

      return numberOfComments;
    } */

}