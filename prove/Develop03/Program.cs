using System;
using System.IO;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        // Scripture Memorization Program written by Chris Johnson 11/2025
        // Set scripture is held in scripture.txt file. ((C:\vscodeCsharp\cse210-hw\prove\Develop03\scripture.txt))

        Program p1 = new Program();
        p1.DisplayMenu();
    }
        public void DisplayMenu()
    {

        //  This is the DisplayMenu method of the Program class.
        //  It loops through completing different cases based on the user choice 1-5.
        //  All cases are handled in this method except the Write choice which is handled in the Entry class.
        //  An entries List variable holds all the journal entries.
        //  A file myJournal.txt holds the journal entries for long term storage. (C:\vscodeCsharp\cse210-hw\prove\Develop02\myJournal.txt)

        string _textFromUser;
        int _userChoice = 0;       

       
		while (_userChoice !=5)
        {
            Console.WriteLine("Welcome to the Scripture Memorization Program!");
			Console.WriteLine("Please select one of the following choices:");
			Console.WriteLine("1. Load Scripture");
			Console.WriteLine("2. Get Scripture");
			Console.WriteLine("3. Get Scripture Reference");
			Console.WriteLine("4. Display and Memorize Scripture");
			//Console.WriteLine("5. Quit");
			Console.Write("What would you like to do?  ");
            _textFromUser = Console.ReadLine();
            _userChoice = int.Parse(_textFromUser);
                	
			Scripture s1 = new Scripture();
            s1.ProcessChoice(_userChoice);	
		}
	}
}