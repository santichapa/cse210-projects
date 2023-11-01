public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _timer;

    public Activity(string name, string description, int timer)
    {
        _activityName = name;
        _description = description;
        _timer = timer;
    }

    public void DisplayMessage() {}
    public void DisplayEndMessage() {}
    public void PauseAnimation() {}
    public void CounterAnimation() {}
}