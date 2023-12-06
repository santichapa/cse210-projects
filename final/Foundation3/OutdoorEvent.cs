public class OutdoorEvent : Event
{
    private string _weather;
    public OutdoorEvent(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string RenderFull()
    {
        return $"Outdoor Event - {_title}\n{_description}\n{_date} - {_time}\n{_weather}\n{_address.GetRenderedAdress()}";
    }
    public override string RenderShort()
    {
        return $"Outdoor Event - {_title}: {_date}";
    }
}