using System;
using System.IO;
using System.Security.Cryptography;
public class Entry
{

    public string GetEntry()
    {

        // GetEntry method of the Entry class to pull quotes from myPrompts.txt file randomly.
        // I have 20 quotes in the text file that are prompts for the Journal entries
        // This method gets the short version of the date.
        // This method organizes the date, prompt, and entry into a string variable textline and returns it to the calling function.


        string _textJournal;
        string _textLine;
        string _currentQuote;
        string _filename2 = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop02\\myPrompts.txt";
        DateTime theCurrentTime = DateTime.Now;
        string _currentDate = theCurrentTime.ToShortDateString();
        List<string> _quotes = new List<string>();
        Random random = new Random();
        int _wheel = 1;

            string[] _qlines = System.IO.File.ReadAllLines(_filename2);
            foreach (string _qline in _qlines)
            {
                _quotes.Add($"{_qline}");
            }
       
            _wheel = random.Next(1, 21);

            Console.WriteLine();
            _currentQuote = _quotes[_wheel];
            Console.WriteLine($"{_currentQuote}");
            Console.WriteLine($"{_currentDate} Type Jurnal entry here.");
            Console.Write(">  ");
            _textJournal = Console.ReadLine();
            _textLine = ($"{_currentDate} {_currentQuote} : {_textJournal}");
            Console.WriteLine();
        
        return _textLine;
    }
}
