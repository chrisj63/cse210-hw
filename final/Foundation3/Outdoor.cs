using System;

class Outdoor : Event
{
    private bool _eventGoodWeather;

    public Outdoor()
    {

    }

    public Outdoor(string GoodWeather)
    {
        GoodWeather = GoodWeather.ToUpper().Trim();
        bool eventGoodWeather = (GoodWeather == "GOOD") ? true : false;
        _eventGoodWeather = eventGoodWeather;
    }

    public bool DisplayOutdoorWeather()
    {
        return _eventGoodWeather;
    }
}
