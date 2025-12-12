using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        // Mindfulness Program written by Chris Johnson 12/2025
        // Mindfulness class is instantiated from here. The MindfulnessMenu() method is called from here.
        // Random prompts for journal entries are held in myPrompts.txt file. ((C:\vscodeCsharp\cse210-hw\prove\Develop04\myPrompts.txt))
        // Using the absolute path and moving the myPrompts.txt and myJournal.txt into the base folder exceeds expectations.
        // This file is read in to the quotes list in the Entry class. (This exceeds the expectation)

        Mindfulness m1 = new Mindfulness();
        m1.MindfulnessMenu(); 
    }


/*

    public int UserOption(int _yourChoice)
    {

        int _localChoice = _yourChoice;
        int _timeSeconds = 10;

        if (_localChoice == 1)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine();
            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.WriteLine();
        }
        
        
        Console.WriteLine("");
        Console.WriteLine("Get ready...");

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

        
        return _localChoice;
    }
    
    public int UserQuestion()
    {
        int _timeSeconds;
        string _textFromUser;

        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session?");
        _textFromUser = Console.ReadLine();
        _timeSeconds = int.Parse(_textFromUser);
        Console.WriteLine("");
        
        return _timeSeconds;
    }
*/
}
	
