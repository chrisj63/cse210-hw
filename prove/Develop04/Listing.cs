using System;
using System.IO;
using System.Security.Cryptography;
public class Listing
{

    public string GetListingName()
    {
        return "Listing Activity.";
    }

    public string GetListingDescription()
    {
        return "reflect on the good things in your life by having you list as many things as you can in a certain area..";
    }


    public void RunListing()
    {

        // RunBreathe method of the Breathe class.


        int _timeSeconds = 30;
        string _textBreatheIn = "Breathe in...";
        string _textBreatheOut = "Now Breathe out...";

        while (_timeSeconds > 0)
        {
            Console.WriteLine();
            for (int i = 4; i >= 0; i -= 1)
            {
                Console.Write($"{_textBreatheIn} {i}");
                Thread.Sleep(500);
                if (i != 0)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // Erase the characters
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Write("\b \b"); // Erase the characters
                    Thread.Sleep(500);
                }

            }
            Console.Write("\b");
            Console.WriteLine();
            for (int j = 6; j >= 0; j -= 1)
            {
                Console.Write($"{_textBreatheOut} {j}");
                Thread.Sleep(500);
                if (j != 0)
                {
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); // Erase the characters
                    Thread.Sleep(500);
                }
                else
                {
                    Console.Write("\b \b"); // Erase the characters
                    Thread.Sleep(500);
                }
            }
            Console.WriteLine();
            _timeSeconds -= 10;

        }
        Console.WriteLine();

        return;
    }
    
}
    

