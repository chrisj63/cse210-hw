using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // This is the Main method of the Program Class.
        // This class handles providing video and comment information to the Video and Comment classes.
        // The Video and Comment classes convert the data into objects and provides a way to display our inventory.

        Console.WriteLine();
        Console.WriteLine("Welcome to the YouTube Video Program");

        Video v1 = new Video("A Day in the Life of a BYU-I Student", "Amy Schneck Blume", 376);
        v1.AddComment("Kourtnie", "Did you see my cartwheels at the end of the video clip?");
        v1.AddComment("Nathan", "Where is my Zyrtec?");
        v1.AddComment("Chris", "This video clip is a bit old.");

        Video v2 = new Video("A Week in the Life - BYU Idaho - Fall Semester", "Meg Caistor", 382);
        v2.AddComment("Meg", "Monday is for Family Home Evening activities... ie the corn maze.");
        v2.AddComment("Meg", "Wednesday I learn playing pool is not my forte!");
        v2.AddComment("Meg", "Thursday is the ballroom dance competition.");
        v2.AddComment("Meg", "Finally, Saturday is soda time.");
        v2.AddComment("Meg", "...And Sunday.... is Church and a day of rest.");

        Video v3 = new Video("How to Survive in Rexburg", "Rachel Saunders", 309);
        v3.AddComment("Rachel", "You can join an intramurals sports team for $8.");
        v3.AddComment("Rachel", "Get caught exting or loitering in the crosswalks? That will cost you $50.");
        v3.AddComment("Taylor", "Remember, Curfew is midnight during the week and 1 am on the weekend.");
        v3.AddComment("Chris", "Rexburg is cold.... Bring a coat!");

        Video v4 = new Video("The Spirit of Ricks and History of BYU-Idaho", "Ben Pingel", 500);
        v4.AddComment("Jacob Spori", "The seeds we are planting today will grow and become mighty oaks and their branches will run all over the earth.");
        v4.AddComment("President David A. Bednar", "The transition from Ricks College to BYU-Idaho was a \"revelation\" and a chance to expand the \"Spirit of Ricks\".");
        v4.AddComment("Chris", "I think it is good to remember where we came from.");

        Console.WriteLine("The following videos are in our current inventory.");

        v1.DisplayVideo();
        v2.DisplayVideo();
        v3.DisplayVideo();
        v4.DisplayVideo();

        Console.WriteLine();
        Console.WriteLine("This is the end");
        Console.WriteLine();

    }

}