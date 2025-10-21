using System;
using System.IO;
using System.Security.Cryptography;
public class Entry
{

    public string GetEntry()
    {

        // GetEntry method of the Entry class to pull quotes from myPrompts.txt file randomly.
        // I have 20 quotes in the text file that are prompts for the Journal entries
        // This method gets the short version of the date.
        // This method organizes the date, prompt, and entry into a string variable textline and returns it to the calling function.


        string textJournal;
        string textLine;
        string currentQuote;
        string filename2 = "myPrompts.txt";
        DateTime theCurrentTime = DateTime.Now;
        string currentDate = theCurrentTime.ToShortDateString();
        List<string> quotes = new List<string>();
        Random random = new Random();
        int wheel = 1;

            string[] qlines = System.IO.File.ReadAllLines(filename2);
            foreach (string qline in qlines)
            {
                quotes.Add($"{qline}");
            }
       
            wheel = random.Next(1, 21);

            Console.WriteLine();
            currentQuote = quotes[wheel];
            Console.WriteLine($"{currentQuote}");
            Console.WriteLine($"{currentDate} Type Jurnal entry here.");
            Console.Write(">  ");
            textJournal = Console.ReadLine();
            textLine = ($"{currentDate} {currentQuote} : {textJournal}");
            Console.WriteLine();
        
        return textLine;
    }
}
