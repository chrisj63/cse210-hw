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
        //  A file myJournal.txt holds the journal entries for long term storage. (\cse210-hw\prove\Develop02\bin\Debug\net8.0>

        string textFromUser;
        string nextEntry;
        string filename = "myJournal.txt";
        int userChoice = 0;       
        List<string> entries = new List<string>();
       
		while (userChoice !=5)
        {
            Console.WriteLine("Welcome to the Journal Program!");
			Console.WriteLine("Please select one of the following choices:");
			Console.WriteLine("1. Write");
			Console.WriteLine("2. Display");
			Console.WriteLine("3. Load");
			Console.WriteLine("4. Save");
			Console.WriteLine("5. Quit");
			Console.Write("What would you like to do?  ");
            textFromUser = Console.ReadLine();
            userChoice = int.Parse(textFromUser);
                	
				switch(userChoice)
				{
                case 1:
                   
                        Entry e1 = new Entry();
                        nextEntry = e1.GetEntry();
                        entries.Add($"{nextEntry} ");
                        Console.WriteLine();
                        
                    break;

                case 2:
                        Console.WriteLine();

                        foreach (string entry in entries)
                        {
                            Console.WriteLine(entry);
                        }
                        
                        Console.WriteLine();
					
                    break;

				case 3:
                        Console.WriteLine();

                        string[] lines = System.IO.File.ReadAllLines(filename);
                            foreach (string line in lines)
                                {
                                    entries.Add($"{line}");
                                }

                        Console.WriteLine("LoadFunction");
                        Console.WriteLine();
					
                    break;

				case 4:
                        Console.WriteLine();

                    using (StreamWriter outputFile = File.AppendText(filename))
                    {
                        foreach (string entry in entries)
                            {
                                outputFile.WriteLine($"{entry}");
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
							
			

