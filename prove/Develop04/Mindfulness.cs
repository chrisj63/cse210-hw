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
    private int _timeSeconds;
    public int _activityTimeSeconds;
    public int _userChoice = 7;

    Breathe b1 = new Breathe();
    Reflect r1 = new Reflect();
    Listing l1 = new Listing();

    public void MindfulnessMenu()
    {
        // This is the MindfulnessMenu method of the Mindfulness class.      
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

        while (userChoice2 != 4)
        {
            Console.Clear();

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
                b1.RunBreathe(_activityTimeSeconds);
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
                r1.RunReflect(_activityTimeSeconds);
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
                l1.RunListing(_activityTimeSeconds);
                endStuff();
                userChoice2 = 4;
            }
        }
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
        string nameList = l1.GetListingName();

        Console.WriteLine();
        Console.WriteLine("Well done!!");
        runSpinner();

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
}