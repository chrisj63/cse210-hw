using System;

public class Reception : Event
{
    private string _eventEmail = "send2receptionregistration@gmail.com";

    public Reception()
    {

    }

    public string DisplayEmailRSVP()
    {
        return _eventEmail;
    }
}