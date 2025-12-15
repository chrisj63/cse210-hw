using System;
using System.Runtime.CompilerServices;

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

    public void AddLecture(string eventLecturer)
    {
        Lecture l1 = new Lecture(eventLecturer);
        _whosTalking.Add(l1);
    }

    public void AddOutdoor(string weather)
    {
        Outdoor out1 = new Outdoor(weather);
        _letsGetOut.Add(out1);
    }

    public void AddReception(bool register, bool rsvp)
    {
        if (!register || rsvp)
        {
            Reception r1 = new Reception(register, rsvp);
            _comeOnOver.Add(r1);
        }
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
    public void DisplayEvent()
    {
        Console.WriteLine();
        Console.WriteLine($"Event Title: {_eventTitle} \r\nEvent Description: {_eventDescription} \r\nEvent Date: {_eventDate} \r\nEventTime: {_eventTime}");
    }

    public void DisplayLecture()
    {
        Console.WriteLine();
        Console.WriteLine($"LectureEvent: {_eventTitle}");
        foreach (Lecture whosTalking in _whosTalking)
        {
            Console.WriteLine($"Event Speaker: {whosTalking.DisplayLecturer()} ");
        }
        Console.WriteLine();
    }

    public void DisplayReception()
    {
        Console.WriteLine();
        Console.WriteLine($"ReceptionEvent: {_eventTitle}");
        foreach (Reception comeOnOver in _comeOnOver)
        {
            Console.WriteLine($"{comeOnOver.DisplayReceptionMessage()}");
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
        Console.WriteLine();
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
}