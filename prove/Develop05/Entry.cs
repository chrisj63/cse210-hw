using System;
using System.IO;
using System.Security.Cryptography;
public class Entry
{
    
    public string _currentDate;
    public string _currentPrompt;
    public string _myJournalResponse;

    public string GetEntry()
    {

        string _listItem;

        _listItem = " " + _currentDate + " " + _currentPrompt + " : "+ _myJournalResponse + " ";
        
        return _listItem;
    }
}
