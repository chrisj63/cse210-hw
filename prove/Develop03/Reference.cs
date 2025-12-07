using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Reference
{
    // Reference Class is holding the active scripture Reference to be memorized.
    // I have initialized all the variables to a scripture that is not in play to assist with troubleshooting.
    
    private string _book = "1st Nephi";
    private int _chapter = 3;
    private int _startVerse = 7;
    private int _lastVerse = 7;

    public Reference(string rbook, int rchapter, int rstartVerse, int rlastVerse)
    {
        _book = rbook;
        _chapter = rchapter;
        _startVerse = rstartVerse;
        _lastVerse = rlastVerse;
    }

    public string Get(int numberOfVerses)
    {
        string ref1;
        string ref2;

        if (numberOfVerses == 1)
        {
            ref1 = "" + _book + " " + _chapter + ":" + _startVerse + " ";
            return ref1;
        }
        else
        {
            ref2 = "" + _book + " " + _chapter + ":" + _startVerse + "-" + _lastVerse + " ";
            return ref2;
        }
    }
}



