using System.ComponentModel.DataAnnotations;

public class ReceptionEvent : Event
{
    private string _email;
    public ReceptionEvent(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string RenderFull()
    {
        return $"Reception Event - {_title}\n{_description}\n{_date} - {_time}\nRSVP/join on {_email}\n{_address.GetRenderedAdress()}";
    }
    public override string RenderShort()
    {
        return $"Reception Event - {_title}: {_date}";
    }
}