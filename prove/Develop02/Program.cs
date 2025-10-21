using System;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        // Journal Entry Program written by Chris Johnson 10/2025
        // Random prompts for journal entries are held in myPrompts.txt file.
        // This file is read in to the quotes list in the Entry class. (This exceeds the expectation)

        Journal j1 = new Journal();
        j1.DisplayMenu();
    }
}	
			
