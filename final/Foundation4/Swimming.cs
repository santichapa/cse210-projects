public class Swimming : Activity
{
    private int _laps;
    public Swimming(string date, int duration) : base(date, duration)
    {

    }

    public override string CalculateDistance()
    {
        return base.CalculateDistance();
    }
    public override string CalculateSpeed()
    {
        return base.CalculateSpeed();
    }
    public override string CalculatePace()
    {
        return base.CalculatePace();
    }
}