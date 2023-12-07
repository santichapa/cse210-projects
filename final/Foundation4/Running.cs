public class Running : Activity
{
    private decimal _distance;
    public Running(string date, int duration, decimal distance) : base(date, duration)
    {
        _type = "Running";
        _distance = distance;
    }

    public override decimal CalculateDistance()
    {
        return _distance;
    }
    public override decimal CalculateSpeed()
    {
        return _distance / (_duration / 60m);
    }
    public override decimal CalculatePace()
    {
        return _duration / _distance;
    }
}