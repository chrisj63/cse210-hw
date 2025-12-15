using System;

class Lecture : Event
{
    private string _eventLecturer;

    public Lecture()
    {

    }

    public Lecture(string eventLecturer)
    {
        _eventLecturer = eventLecturer;
    }

    public string DisplayLecturer()
    {
        return _eventLecturer;
    }
}