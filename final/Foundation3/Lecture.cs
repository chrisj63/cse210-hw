using System;

class Lecture : Event
{
    private string _eventLecturer;
    private bool _eventRSVP;
    private bool _eventRegister;
    private int _eventRegistered = 49;
    private int _eventRSVPd = 20;
    private int _eventMaxParticipants = 50;

    public Lecture()
    {

    }

    public Lecture(bool eventRSVP)
    {
        _eventRSVP = eventRSVP;
    }

    public Lecture(string eventLecturer)
    {
        _eventLecturer = eventLecturer;
    }

    public string DisplayLecturer()
    {
        return _eventLecturer;
    }

    public Lecture(bool eventRegister, bool eventRSVP)
    {
        _eventRegister = eventRegister;
        _eventRSVP = eventRSVP;
        if (!eventRegister)
        {
            _eventRegistered++;
        }
        if (eventRSVP)
        {
            _eventRSVPd++;
        }

    }

    public string DisplayLectureMessage()
    {
        int slotsLeft = _eventMaxParticipants - _eventRegistered;
        bool slotsAvailable = (slotsLeft > 0) ? true : false;
        string tempString;

        tempString = "\r\n";
        if (slotsAvailable)
        {
            tempString = tempString + "You have been registered as a participant. There ";

            if (slotsLeft > 1)
            {
                tempString = tempString + "are " + slotsLeft + " slots left.";
            }
            else
            {
                tempString = tempString + "is " + slotsLeft + " slot left.";
            }
        }
        else
        {
            tempString = tempString + "You have NOT been registered as a participant. There are no more slots available.";
        }
        tempString = tempString + "\r\nThere are " + _eventRegistered + " registered out of " + _eventMaxParticipants + " possible.";
        tempString = tempString + "\r\nWe have received " + _eventRSVPd + " responses from people who are coming.";
        return tempString;
    }
}