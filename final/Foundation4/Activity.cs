public abstract class Activity
{
    protected string _date;
    protected int _duration;

    public Activity(string date, int duration)
    {
        _date = date;
        _duration = duration;
    }

    public void GetSummary()
    {
        
    }
    public virtual string CalculateDistance()
    {
        return "";
    }
    public virtual string CalculateSpeed()
    {
        return "";
    }
    public virtual string CalculatePace()
    {
        return "";
    }

}