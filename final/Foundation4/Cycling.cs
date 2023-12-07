public class Cycling : Activity
{
    private decimal _speed;
    public Cycling(string date, int duration, decimal speed) : base(date, duration)
    {   
        _speed = speed;
        _type = "Cycling";
    }

    public override decimal CalculateDistance()
    {
        return _speed * (_duration / 60m);
    }
    public override decimal CalculateSpeed()
    {
        return _speed;
    }
    public override decimal CalculatePace()
    {
        return _duration / CalculateDistance();
    }
}