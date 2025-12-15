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
        // The e2 Outdoor event on December 30 was cancelled due to bad weather.
        // The e3 Outdoor event on December 31 will go forward as planned due to good weather.
        // The e4 Reception event has an entry with true for registered (no need to register) and true for RSVP (increased participant count).
        // The e4 Reception event has an entry with false for registered (increased registered count... event was full... registration was denied.) and true for RSVP (increased participant count).

        Console.WriteLine();
        Console.WriteLine("Welcome to the Event Planning program");

        Event e1 = new Event("BYU-I Christmas Party", "Christmas party for the C# class", "December 18, 2025", "06:00 PM");
        e1.AddAddress("60 North Temple", "Salt Lake City", "UT", "84150", "usa");
        e1.AddLecture("President Dallin H. Oaks");

        Event e2 = new Event("BYU-I New Years Eve Skating Party", "Ice Skating party for Rexburg on-campus students.", "December 30, 2025", "07:00 PM");
        e2.AddAddress("1114 N Yellowstone Hwy", "Rexburg", "ID", "83340", "USA");
        e2.AddOutdoor("Bad");

        Event e3 = new Event("BYU-I New Years Eve Skating Party", "Ice Skating party for Rexburg on-campus students.", "December 31, 2025", "07:00 PM");
        e3.AddAddress("1114 N Yellowstone Hwy", "Rexburg", "ID", "83340", "USA");
        e3.AddOutdoor("Good");

        Event e4 = new Event("BYU-I Job Fair", "Employers meet with students in the Manwaring Center", "January 8, 2026", "10:00 AM");
        e4.AddAddress("101 E Viking St", "Rexburg", "ID", "83460", "USA");
        e4.AddReception(true, true);

        Event e5 = new Event("BYU-I Job Fair", "Employers meet with students in the Manwaring Center", "January 13, 2026", "10:00 AM");
        e5.AddAddress("101 E Viking St", "Rexburg", "ID", "83460", "USA");
        e5.AddReception(false, true);

        Console.WriteLine("The following events are reserved.");

        e1.DisplayEvent();
        e1.DisplayAddress();
        e1.DisplayLecture();
        e2.DisplayEvent();
        e2.DisplayAddress();
        e2.DisplayOutdoor();
        e3.DisplayEvent();
        e3.DisplayAddress();
        e3.DisplayOutdoor();
        e4.DisplayEvent();
        e4.DisplayAddress();
        e4.DisplayReception();
        e5.DisplayEvent();
        e5.DisplayAddress();
        e5.DisplayReception();

        Console.WriteLine("This is the end");
        Console.WriteLine();
    }
}