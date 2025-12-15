using System;

class Program
{
    static void Main(string[] args)
    {
        // This is the event planning program written by Chris Johnson in December 2025.
        // This is the Main method of the Program Class.
        // This class handles providing Lecture, Outdoor, Reception and Address information to the corresponding classes.
        // The Lecture, Outdoor, Reception,and Address classes convert the data into objects and provides a way to display our reservations.
        // The Event class is the base class. The other classes inherit data from the Event class.
        // The e1 Lecture event has a passed argument of true for registered (no need to register) and true for RSVP (increased participant count).
        // The e2 Lecture event has a passed argument of false for registered (increased registered count... event was full... registration was denied.) and true for RSVP (increased participant count). 
        // The e3 Outdoor event on December 30 was cancelled due to bad weather.
        // The e4 Outdoor event on December 31 will go forward as planned due to good weather.
        // The e5 Reception event requires an RSVP to the email provided.

        Console.WriteLine();
        Console.WriteLine("Welcome to the Event Planning program");

        Event e1 = new Event("BYU-I Christmas Party", "Christmas party for the C# class", "December 18, 2025", "06:00 PM");
        e1.AddAddress("60 North Temple", "Salt Lake City", "UT", "84150", "usa");
        e1.AddLecture("President Dallin H. Oaks");
        e1.AddLecture(true, true);

        Event e2 = new Event("BYU-I Christmas Party", "Christmas party for the C# class", "December 18, 2025", "06:00 PM");
        e2.AddAddress("60 North Temple", "Salt Lake City", "UT", "84150", "usa");
        e2.AddLecture("President Dallin H. Oaks");
        e2.AddLecture(false, true);


        Event e3 = new Event("BYU-I New Years Eve Skating Party", "Ice Skating party for Rexburg on-campus students.", "December 30, 2025", "07:00 PM");
        e3.AddAddress("1114 N Yellowstone Hwy", "Rexburg", "ID", "83340", "USA");
        e3.AddOutdoor("Bad");

        Event e4 = new Event("BYU-I New Years Eve Skating Party", "Ice Skating party for Rexburg on-campus students.", "December 31, 2025", "07:00 PM");
        e4.AddAddress("1114 N Yellowstone Hwy", "Rexburg", "ID", "83340", "USA");
        e4.AddOutdoor("Good");

        Event e5 = new Event("BYU-I Job Fair", "Employers meet with students in the Manwaring Center", "January 8, 2026", "10:00 AM");
        e5.AddAddress("101 E Viking St", "Rexburg", "ID", "83460", "USA");
        e5.AddReception();

        Console.WriteLine("The following events are reserved.");

        e1.DisplayStandardDetails();
        e1.DisplayBreak();
        e1.DisplayFullDetails("l");
        e1.DisplayBreak();
        e1.DisplayShortDescription("l");
        e1.DisplayBreak();

        e2.DisplayStandardDetails();
        e2.DisplayBreak();
        e2.DisplayFullDetails("l");
        e2.DisplayBreak();
        e2.DisplayShortDescription("l");
        e2.DisplayBreak();

        e3.DisplayStandardDetails();
        e3.DisplayBreak();
        e3.DisplayFullDetails("o");
        e3.DisplayBreak();
        e3.DisplayShortDescription("o");
        e3.DisplayBreak();

        e4.DisplayStandardDetails();
        e4.DisplayBreak();
        e4.DisplayFullDetails("o");
        e4.DisplayBreak();
        e4.DisplayShortDescription("o");
        e4.DisplayBreak();

        e5.DisplayStandardDetails();
        e5.DisplayBreak();
        e5.DisplayFullDetails("r");
        e5.DisplayBreak();
        e5.DisplayShortDescription("r");
        e5.DisplayBreak();

        Console.WriteLine("This is the end");
        Console.WriteLine();
    }
}