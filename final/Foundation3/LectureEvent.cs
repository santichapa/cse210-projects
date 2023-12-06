public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string RenderFull()
    {
        return $"Lecture Event - {_title}\nby {_speaker}\n{_description}\n{_date} - {_time}\nCapacity: {_capacity}\n{_address.GetRenderedAdress()}";
    }
    public override string RenderShort()
    {
        return $"Lecture Event - {_title}: {_date}";
    }
}