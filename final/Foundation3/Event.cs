using System.Collections.Specialized;
using System.Net.Sockets;

public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string RenderStandard()
    {
        return $"{_title}\n{_description}\n{_date} - {_time}\n{_address.GetRenderedAdress()}";
    }
    public abstract string RenderFull();
    public abstract string RenderShort();
}