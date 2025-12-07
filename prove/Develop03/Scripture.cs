using System;
using System.Dynamic;
using System.IO;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Scripture
{

    private string _textScripture1 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection.";
    private string _textScripture2 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection.  And if a person gains more knowledge and intelligence in this life through his diligence and obedience than another, he will have so much the advantage in the world to come. ";
    private string _scriptureReference;
    private bool _allActive = true;
    private bool _oneVerse = true;
    private bool _quit = false;
    private List<Word> _scriptureWords = new List<Word>();
    private List<int> _hiddenWords = new List<int>();

    Reference r1 = new Reference("Doctrine and Covenants", 130, 18, 19);
    Random _randomGenerator = new Random();

    public void ScriptureMenu()
    {
        // This is the ScriptureMenu method of the Scripture class.
        // textScripture1 stores one verse. textScripture2 stores two verses. A Menu choice 1 or 2 decides which variable to pass to the SpliceScripture2() method.
        // The scripture is stored in the _scriptureWords List of Word Objects.
        // A second List -hiddenWords keeps track of how many words have had their _active attribute changed to false.
        // When all words _active attribute become false, the _allActive variable is changed to false.
        // _scriptureReference is retrieved from the r1 Reference Class that was constructed when the program is run. 2 methods are available to choose one or two verses.
        // When all words in the verse are displayed as "____", then the _quit variable is changed to true.
        // _oneVerse boolean variable determines which menu item was selected and helps determine the number of words that are in play.
        // _RandomGenerator is utilized to pick 3 random index numbers from the list to hide for each round.

        string textFromUser;
        int userChoice = 0;

        while (userChoice != 5)
        {
            Console.WriteLine("Welcome to the Scripture Memorization Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Memorize one verse");
            Console.WriteLine("2. Memorize two verses");
            Console.WriteLine("5. Exit Program");
            Console.WriteLine("What would you like to do?  ");
            textFromUser = Console.ReadLine();

            if (textFromUser == "quit")
            {
                userChoice = 5;
            }
            else
            {
                userChoice = int.Parse(textFromUser);
                Console.WriteLine();
            }

            if (userChoice == 1)
            {
                DisplayScripture(1);
                userChoice = 5;
            }

            if (userChoice == 2)
            {
                _oneVerse = false;
                DisplayScripture(2);
                userChoice = 5;
            }

            if (userChoice == 5)
            {

            }
        }
    }
 
    public void DisplayScripture(int localUserChoice)
    {
        int userChoice2 = 1;
        string textFromUser2;
        int runCount = 1;

        while (userChoice2 != 5 && _allActive == true)
        {
            Console.Clear();

            if (runCount == 1)
            {
                if (localUserChoice == 1)
                {
                    _scriptureReference = r1.Get(1);
                    SpliceScripture2(_textScripture1);
                }

                if (localUserChoice == 2)
                {
                    _scriptureReference = r1.Get(2);
                    SpliceScripture2(_textScripture2);
                }
                ScriptureOutputMethod();
            }

            if (_quit == true)
            {
                _allActive = false;
            }
            if (runCount != 1 && _allActive == true)
            {
                ScriptureActiveOutputMethod();
            }

            runCount++;
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            textFromUser2 = Console.ReadLine().ToLower().Trim();

            if (textFromUser2 == "quit")
            {
                userChoice2 = 5;
            }

            if (_allActive == false && _quit == true)
            {
                userChoice2 = 5;
            }
        }
    }

    public void SpliceScripture2(string localWord)
    {
        // This method takes the scripture string that is passed in and separates it into words and adds each word as a List item.

        string whole = localWord;

        string[] words = whole.Split(" ");

        foreach (string text in words)
        {
            _scriptureWords.Add(new Word(text));
        }
    }

    public void ScriptureOutputMethod()
    {
        Console.WriteLine($"{_scriptureReference}");
        foreach (Word word in _scriptureWords)
        {
            string last;
            last = word.Display();
            Console.Write($"{last} ");
            Console.Write(" ");
        }
        Console.WriteLine();
    }

    public void ScriptureActiveOutputMethod()
    {
        int count2 = 0;

        while (count2 < 3 && _allActive == true)
        {
            int magicNumber = _randomGenerator.Next(0, _scriptureWords.Count);

            if (_scriptureWords[magicNumber]._active == true)
            {
                {
                    _scriptureWords[magicNumber].Hide();
                    _hiddenWords.Add(magicNumber);
                    count2++;
                }

                foreach (int number in _hiddenWords)
                {
                    int test5 = _hiddenWords.Count;

                    if (_oneVerse)
                    {
                        if (test5 >= 18)
                        {
                            _quit = true;
                        }
                    }
                    else
                    {
                        if (test5 >= 51)
                        {
                            _quit = true;
                        }
                    }
                }
            }
        }

        // The following is needed to get the proper end to the program by displaying all the "____" words and then hitting the enter key to close out the program.

        if (_quit == false && _allActive == true)
        {
            ScriptureOutputMethod();
        }

        if (_quit == true && _allActive == true)
        {
            ScriptureOutputMethod();
        }
        if (_quit == true)
        {
            _allActive = false;
        }
    }
}