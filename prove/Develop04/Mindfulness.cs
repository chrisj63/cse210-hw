using System;
using System.Dynamic;
using System.IO;
using System.Net.Quic;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Mindfulness
{

  //  private string _textScripture1 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection.";
   // private string _textScripture2 = "Whatever principle of intelligence we attain unto in this life, it will rise with us in the resurrection.  And if a person gains more knowledge and intelligence in this life through his diligence and obedience than another, he will have so much the advantage in the world to come. ";
   // private string _scriptureReference;
    private bool _allActive = true;
    private int _timeSeconds;
    public int _activityTimeSeconds;
    public int _userChoice = 7;
    private bool _quit = false;
   // private List<Word> _scriptureWords = new List<Word>();
  //  private List<int> _hiddenWords = new List<int>();

    Breathe b1 = new Breathe();
    Reflect r1 = new Reflect();
    Listing l1 = new Listing();
   //Mindfulness m2 = new Mindfulness();


   // Random _randomGenerator = new Random();

    public void MindfulnessMenu()
    {
        // This is the MindfulnessMenu method of the Mindfulness class.
        // textScripture1 stores one verse. textScripture2 stores two verses. A Menu choice 1 or 2 decides which variable to pass to the SpliceScripture2() method.
        // The scripture is stored in the _scriptureWords List of Word Objects.
        // A second List -hiddenWords keeps track of how many words have had their _active attribute changed to false.
        // When all words _active attribute become false, the _allActive variable is changed to false.
        // _scriptureReference is retrieved from the r1 Reference Class that was constructed when the program is run. 2 methods are available to choose one or two verses.
        // When all words in the verse are displayed as "____", then the _quit variable is changed to true.
        // _oneVerse boolean variable determines which menu item was selected and helps determine the number of words that are in play.
        // _RandomGenerator is utilized to pick 3 random index numbers from the list to hide for each round.

        string textFromUser;
        _userChoice = 9;

        while (_userChoice != 4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start breathing activity");
            Console.WriteLine("    2. Start reflecting activity");
            Console.WriteLine("    3. Start listing activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("Select a choice from the menu:");
            textFromUser = Console.ReadLine();
            _userChoice = int.Parse(textFromUser);

            Console.WriteLine($"first userChoice: {_userChoice}");

            if (textFromUser == "quit")
            {
                _userChoice = 4;
            }
           // else
           // {
//
            //    Console.WriteLine();
           // }

            if (_userChoice == 1)
            {
                DisplayMindfulness(1);
                _userChoice = 0;
            }

            if (_userChoice == 2)
            {
                DisplayMindfulness(2);
                _userChoice = 0;
            }
            if (_userChoice == 3)
            {
                DisplayMindfulness(3);
                _userChoice = 0;
            }

            if (_userChoice == 4)
            {

            }
        }
    }
    public void DisplayMindfulness(int localUserChoice)
    {
        int userChoice2 = localUserChoice;
        string textFromUser2;
        //int runCount = 1;

        while (userChoice2 != 4)
        {
            Console.Clear();

           // if (runCount == 1)
           // {
                if (userChoice2 == 1)
                {
                    Console.Write(GetMindfulWelcome());
                    Console.WriteLine(b1.GetBreatheName());
                    Console.WriteLine();
                    Console.Write(GetMindfulDescription());
                    Console.WriteLine(b1.GetBreatheDescription());
                    Console.WriteLine();
                    Console.Write(GetMindfulSeconds());
                    textFromUser2 = Console.ReadLine();
                    _activityTimeSeconds = int.Parse(textFromUser2);
                    GetReady();
                    b1.RunBreathe();
                    endStuff();
                    userChoice2 = 4;
                   
                }

                if (userChoice2 == 2)
                {
                    Console.Write(GetMindfulWelcome());
                    Console.WriteLine(r1.GetReflectName());
                    Console.WriteLine();
                    Console.Write(GetMindfulDescription());
                    Console.WriteLine(r1.GetReflectDescription());
                    Console.WriteLine();
                    Console.Write(GetMindfulSeconds());
                    textFromUser2 = Console.ReadLine();
                    _activityTimeSeconds = int.Parse(textFromUser2);
                    GetReady();
                    b1.RunBreathe();
                    endStuff();
                    userChoice2 = 4;
                } 

                if (userChoice2 == 3)
                {
                    Console.Write(GetMindfulWelcome());
                    Console.WriteLine(l1.GetListingName());
                    Console.WriteLine();
                    Console.Write(GetMindfulDescription());
                    Console.WriteLine(l1.GetListingDescription());
                    Console.WriteLine();
                    Console.Write(GetMindfulSeconds());
                    textFromUser2 = Console.ReadLine();
                    _activityTimeSeconds = int.Parse(textFromUser2);
                    GetReady();
                    b1.RunBreathe();
                    endStuff();
                    userChoice2 = 4;
                } 
        }
                
            
            
            /*
            if (_quit == true)
            {
                _allActive = false;
            }
            if (runCount != 1 && _allActive == true)
            {
           //     ScriptureActiveOutputMethod();
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
            }*/
       // }
    }

    private string GetMindfulWelcome()
    {
        return "Welcome to the ";
    }
    private string GetMindfulDescription()
    {
        return "This activity will help you ";
    }
    private string GetMindfulSeconds()
    {
        return "How long, in seconds, would you like for your session?";
    }

    private void GetReady()
    {
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        runSpinner();
    }

    private void runSpinner()
    {
       _timeSeconds = 5;
        while (_timeSeconds > 0)
        {
            for (int i = 6; i >= 0; i -= 1)
            {
                Console.Write("|");
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the characters
                Console.Write("/");
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the characters
                Console.Write("-");
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the characters
                Console.Write("\\");
                Thread.Sleep(250);
                Console.Write("\b \b"); // Erase the characters
            }
            _timeSeconds -= 5;
        }
    
        Console.WriteLine();

        Thread.Sleep(2000);
       
    }

    private void endStuff()
    {
        //Breathe b1 = new Breathe();
        string nameBreathe = b1.GetBreatheName();

       // Reflect r1 = new Reflect();
        string nameReflect = r1.GetReflectName();

       // Listing l1 = new Listing();
     //   string nameList = b1.GetListingName();
        string nameList = l1.GetListingName();
        
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        runSpinner();

        Console.WriteLine($"_userChoice: {_userChoice}");
        Console.WriteLine($"Seconds: {_activityTimeSeconds}");

        if (_userChoice == 1)
        {  
            Console.WriteLine();
            Console.WriteLine($"You have completed another {_activityTimeSeconds} seconds of the {nameBreathe}");  
            Console.WriteLine();
            Thread.Sleep(3000);
        }

        if (_userChoice == 2)
        {  
          Console.WriteLine();
          Console.WriteLine($"You have completed another {_activityTimeSeconds} seconds of the {nameReflect}");  
          Console.WriteLine();
        }

        if (_userChoice == 3)
        {  
          Console.WriteLine();
          Console.WriteLine($"You have completed another {_activityTimeSeconds} seconds of the {nameList}");  
          Console.WriteLine();
        }

       
    }

/*
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

                 //   if (_oneVerse)
                    {
                        if (test5 >= 18)
                        {
                            _quit = true;
                        }
                    }
                  //  else
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
    } */
}