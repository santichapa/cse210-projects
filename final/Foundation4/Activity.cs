public abstract class Activity
{
    protected string _date;
    protected int _duration;
    protected string _type;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public string GetSummary()
    {
        return $"    > {_date} {_type} ({_duration} min): Distance: {Math.Round(CalculateDistance(), 1, MidpointRounding.AwayFromZero)} km, Speed: {Math.Round(CalculateSpeed(), 2, MidpointRounding.AwayFromZero)} kph, Pace: {Math.Round(CalculatePace(), MidpointRounding.AwayFromZero)} minutes per km";
    }
    public virtual decimal CalculateDistance()
    {
        return 0;
    }
    public virtual decimal CalculateSpeed()
    {
        return 0;
    }
    public virtual decimal CalculatePace()
    {
        return 0;
    }

}