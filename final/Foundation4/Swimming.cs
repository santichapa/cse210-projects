public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        _type = "Swimming";
        _laps = laps;
    }

    public override decimal CalculateDistance()
    {
        return 50m * _laps / 1000;
    }
    public override decimal CalculateSpeed()
    {
        return CalculateDistance() / _duration * 60;
    }
    public override decimal CalculatePace()
    {
        return 60 / CalculateSpeed();
    }
}