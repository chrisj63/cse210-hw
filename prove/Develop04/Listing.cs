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

    public void RunListing(int listingTime)
    {
        // RunBreathe method of the Breathe class.
        int timeSeconds = listingTime;
        string textBreatheIn = "Breathe in...";
        string textBreatheOut = "Now Breathe out...";

        while (timeSeconds > 0)
        {
            Console.WriteLine();
            for (int i = 4; i >= 0; i -= 1)
            {
                Console.Write($"{textBreatheIn} {i}");
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
                Console.Write($"{textBreatheOut} {j}");
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
            timeSeconds -= 10;
        }
        Console.WriteLine();
        return;
    }
}


