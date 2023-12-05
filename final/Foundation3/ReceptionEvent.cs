public class ReceptionEvent : Event
{
    public ReceptionEvent(string title, string description, string date, string time, Address address) : base(title, description, date, time, address)
    {
    }

    public override void DisplayFull()
    {
        
    }
}