public class Cycling : Activity
{
    private decimal _speed;
    public Cycling(string date, int duration) : base(date, duration)
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