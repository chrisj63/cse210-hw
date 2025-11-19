using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Journal
{

        string _journalEntryFilename = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop05\\myJournal.txt";
        string _promptFilename = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop05\\myPrompts.txt";
        List<string> _prompts = new List<string>();
        List<string> _entries = new List<string>();
   
     public void DisplayMenu()
    {

        //  This is the DisplayMenu method of the Program class.
        //  It loops through completing different cases based on the user choice 1-5.
        //  All cases are handled in this method.
        //  An entries List variable holds all the journal entries.
        //  A file myJournal.txt holds the journal entries for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop05\myJournal.txt)

        string _textFromUser;
        string _nextEntry;
        int _userChoice = 0;
       
		while (_userChoice !=5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
			Console.WriteLine("Please select one of the following choices:");
			Console.WriteLine("1. Write");
			Console.WriteLine("2. Display");
			Console.WriteLine("3. Load");
			Console.WriteLine("4. Save");
			Console.WriteLine("5. Quit");
			Console.Write("What would you like to do?  ");
            _textFromUser = Console.ReadLine();
            _userChoice = int.Parse(_textFromUser);

            switch (_userChoice)
            {
                case 1:

                    _nextEntry =WriteEntry();
                    _entries.Add($"{_nextEntry} ");
                    Console.WriteLine();
                    Console.WriteLine(_entries[0]);
                    Console.WriteLine();

                    break;

                case 2:
                    Console.WriteLine();

                    foreach (string _entry in _entries)
                    {
                        Console.WriteLine(_entry);
                    }

                    Console.WriteLine();
                    
                    break;

                case 3:
                    Console.WriteLine();

                    string[] _lines = System.IO.File.ReadAllLines(_journalEntryFilename);
                    foreach (string _line in _lines)
                    {
                        _entries.Add($"{_line}");
                    }

                    Console.WriteLine("LoadFunction");
                    Console.WriteLine();

                    break;

                case 4:
                    Console.WriteLine();

                    using (StreamWriter outputFile = File.AppendText(_journalEntryFilename))
                    {
                        foreach (string _entry in _entries)
                        {
                            outputFile.WriteLine($"{_entry}");
                        }
                    }

                    Console.WriteLine("SaveFunction");
                    Console.WriteLine();

                    break;

                case 5:

                    Console.WriteLine();
                    Console.WriteLine("QuitFunction");
                    Console.WriteLine();

                    break;

                default:

                    Console.WriteLine();
                    Console.WriteLine("Make a different choice, Try Again");
                    Console.WriteLine();

                    break;
            }
   
        }
    }

    public string WriteEntry()
    {
        string _textJournal;
        string _textLine;
        string _currentPrompt;
        DateTime theCurrentTime = DateTime.Now;
        string _currentDate = theCurrentTime.ToShortDateString();
        Random _random = new Random();
        int _wheel;

            string[] _qlines = System.IO.File.ReadAllLines(_promptFilename);
            foreach (string _qline in _qlines)
            {
                _prompts.Add($"{_qline}");
            }
       
            _wheel = _random.Next(1, 21);

            Console.WriteLine();
            _currentPrompt = _prompts[_wheel];
            Console.WriteLine($"{_currentPrompt}");
            Console.WriteLine($"{_currentDate} Type journal entry here.");
            Console.Write(">  ");
            _textJournal = Console.ReadLine();
            Entry e1 = new Entry();
            e1._currentDate = _currentDate;
            e1._currentPrompt = _currentPrompt;
            e1._myJournalResponse = _textJournal;
            _textLine = e1.GetEntry();
            Console.WriteLine();
        
        return _textLine;

    }
    
}

  
							
			

