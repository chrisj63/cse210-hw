using System;
using System.Dynamic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{

        string _nextEntry;
        string _filename1 = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop03\\scripture.txt";
        string _filename2 = "C:\\vscodeCsharp\\cse210-hw\\prove\\Develop03\\reference.txt";
        int _localUserChoice;
        string _scriptureReference;
        List<string> _scriptureWords = new List<string>();
        
         List<string> _scriptureWordsVisible = new List<string>();
    public void ProcessChoice(int _userChoice)
    {

        //  This is the DisplayMenu method of the Program class.
        //  It loops through completing different cases based on the user choice 1-5.
        //  All cases are handled in this method except the Write choice which is handled in the Entry class.
        //  An entries List variable holds all the journal entries.
        //  A file scripture.txt holds the scripture entry for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop03\scripture.txt)
        //  A file reference.txt holds the scripture reference entry for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop03\reference.txt)


        _localUserChoice = _userChoice;


        switch (_localUserChoice)
        {
            case 1:

                Console.WriteLine();

                string[] _lines = System.IO.File.ReadAllLines(_filename1);
                foreach (string _line in _lines)
                {
                    _scriptureWords.Add($"{_line}");
                    Console.WriteLine($"{_line}");
                }

                Console.WriteLine();
                Console.WriteLine("LoadFunction");
                Console.WriteLine();


                break;

            case 2:
                Console.WriteLine();

                _scriptureWordsVisible = _scriptureWords;
                
                foreach (string _line in _scriptureWordsVisible)
                {
                    Console.WriteLine($"{_line}");
                }

                Console.WriteLine();
                Console.WriteLine("GetFunction");
                Console.WriteLine();

                break;

            case 3:
                
                Console.WriteLine();

                string[] _texts = System.IO.File.ReadAllLines(_filename2);
                foreach (string _text in _texts)
                {
                    _scriptureReference = _text;
                }

                Console.WriteLine();
                Console.WriteLine("Get Scripture Reference Function " + _scriptureReference + " .");
                Console.WriteLine();

                break;

            case 4:

                Console.WriteLine($" " + _scriptureReference + " ");

                foreach (string _line in _scriptureWordsVisible)
                {
                    Console.WriteLine($"{_line}");
                }

                Console.WriteLine();
                Console.WriteLine("Display and Memorize Scripture");
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
        return;
    }
}  
							
			

