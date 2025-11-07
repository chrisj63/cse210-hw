using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Journal
{

	public void DisplayMenu()
    {

        //  This is the DisplayMenu method of the Journal class.
        //  It loops through completing different cases based on the user choice 1-5.
        //  All cases are handled in this method except the Write choice which is handled in the Entry class.
        //  An entries List variable holds all the journal entries.
        //  A file myJournal.txt holds the journal entries for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop04\myJournal.txt)

        string _textFromUser;
        string _nextEntry;
        string _filename = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop04\\myJournal.txt";
        int _userChoice = 0;
        int _sessionTime;       
        List<string> _entries = new List<string>();
       
		while (_userChoice !=5)
        {
    		Console.WriteLine("Menu Options:");
			Console.WriteLine("1. Start breathing activity");
			Console.WriteLine("2. Start reflection activity");
			Console.WriteLine("3. Start listing activity");
			Console.WriteLine("4. Save");
			Console.WriteLine("5. Quit");
			Console.Write("Select a choice from the menu: ");
            _textFromUser = Console.ReadLine();
            _userChoice = int.Parse(_textFromUser);
                	
				switch(_userChoice)
				{
                case 1:

                    Program p2 = new Program();
                    _sessionTime = p2.UserQuestion();

                    Console.WriteLine ($"Session Time is: {_sessionTime}");
                    
                    Program p1 = new Program();
                    p1.UserOption(1);

                    Breathe b1 = new Breathe();
                    b1.RunBreathe(_sessionTime);

                    
                        
                       /* Entry e1 = new Entry();
                        _nextEntry = e1.GetEntry();
                        _entries.Add($"{_nextEntry} ");
                        Console.WriteLine(); */
                        
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

                        string[] _lines = System.IO.File.ReadAllLines(_filename);
                            foreach (string _line in _lines)
                                {
                                    _entries.Add($"{_line}");
                                }

                        Console.WriteLine("LoadFunction");
                        Console.WriteLine();
					
                    break;

				case 4:
                        Console.WriteLine();

                    using (StreamWriter outputFile = File.AppendText(_filename))
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
}  
							
			

