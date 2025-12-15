using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;

    private List<Event> _whatsHappening = new List<Event>();
    private List<Lecture> _whosTalking = new List<Lecture>();
    private List<Outdoor> _letsGetOut = new List<Outdoor>();
    private List<Reception> _comeOnOver = new List<Reception>();
    private List<Address> _livesWhere = new List<Address>();


    public void AddReception()
    {
        Reception r1 = new Reception();
        _comeOnOver.Add(r1);
    }
    
    public void AddLecture(string eventLecturer)
    {
        Lecture l1 = new Lecture(eventLecturer);
        _whosTalking.Add(l1);
    }

    public void AddLecture(bool register, bool rsvp)
    {
        if (!register || rsvp)
        {
            Lecture l1 = new Lecture(register, rsvp);
            _whosTalking.Add(l1);
        }
    }
    
    public void AddOutdoor(string weather)
    {
        Outdoor out1 = new Outdoor(weather);
        _letsGetOut.Add(out1);
    }

    public void AddAddress(string streetAddress, string city, string state, string zipCode, string country)
    {
        Address a1 = new Address(streetAddress, city, state, zipCode, country);
        _livesWhere.Add(a1);
    }

    public Event()
    {

    }

    public Event(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public Event(string eventTitle, string eventDescription, string eventDate, string eventTime)
    {
        _eventTitle = eventTitle;
        _eventDescription = eventDescription;
        _eventDate = eventDate;
        _eventTime = eventTime;
    }

    public void DisplayStandardDetails()
    {
        DisplayEvent();
        DisplayAddress();
        Console.WriteLine();
    }

    public void DisplayFullDetails(string type)
    {
        DisplayStandardDetails();
        if (type == "l")
        {
            DisplayLecture();
        }
        else if (type == "o")
        {
            DisplayOutdoor();
        }
        else if (type == "r")
        {
            DisplayReception();
        }
        else
        {

        }
    }

    public void DisplayShortDescription(string type)
    {
        if (type == "l")
        {
            Console.WriteLine($"LectureEvent: {_eventTitle} on {_eventDate}");
        }
        else if (type == "o")
        {
            Console.WriteLine($"OutdoorEvent: {_eventTitle} on {_eventDate}");
        }
        else if (type == "r")
        {
            Console.WriteLine($"ReceptionEvent: {_eventTitle} on {_eventDate}");
        }
        else
        {
        }
    }

    public void DisplayEvent()
    {
        Console.WriteLine();
        Console.WriteLine($"Event Title: {_eventTitle} \r\nEvent Description: {_eventDescription} \r\nEvent Date: {_eventDate} \r\nEventTime: {_eventTime}");
    }

    public void DisplayReception()
    {
        Console.WriteLine();
        foreach (Reception comeOnOver in _comeOnOver)
        {
            Console.WriteLine($"ReceptionEvent: {_eventTitle}");
            Console.WriteLine($"Please RSVP to {comeOnOver.DisplayEmailRSVP()}");
        }
    }
    
    public void DisplayLecture()
    {
        Console.WriteLine();
        Console.WriteLine($"LectureEvent: {_eventTitle}");
        int count = 0;
        foreach (Lecture whosTalking in _whosTalking)
        {
            if (count == 0)
            {
                Console.WriteLine($"Speaker: {whosTalking.DisplayLecturer()}");
            }
            if (count > 0)
            {
                Console.WriteLine($"{whosTalking.DisplayLectureMessage()}");
            }
            count++;
        }
        Console.WriteLine();
    }

    public void DisplayOutdoor()
    {
        Console.WriteLine();
        Console.WriteLine($"OutdoorEvent: {_eventTitle}");
        foreach (Outdoor letsGetOut in _letsGetOut)
        {
            if (letsGetOut.DisplayOutdoorWeather())
            {
                Console.WriteLine("Weather is good.... Event goes on as planned.");
            }
            else
            {
                Console.WriteLine("Weather is bad.... Event is cancelled.");
            }
        }
    }

    public void DisplayAddress()
    {
        Console.WriteLine();
        Console.WriteLine($"{_eventTitle}");
        Console.WriteLine("Event Address:");
        foreach (Address livesWhere in _livesWhere)
        {
            Console.WriteLine($"{livesWhere.DisplayAddress()} ");
        }
    }

    public void DisplayBreak()
    {
        Console.WriteLine("----------------------------------");
    }
}