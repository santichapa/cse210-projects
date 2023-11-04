public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _timer;
    protected int _activityCounter;

    public Activity()
    {
    }
    public Activity(string name, string description, int timer, int activityCounter)
    {
        _activityName = name;
        _description = description;
        _timer = timer;
        _activityCounter = activityCounter;
    }

    public void DisplayMessage() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}.");
        GetActivityCount();
        Console.WriteLine(_description);
    }
    public void DisplayEndMessage() {
        Console.WriteLine($"\nYou have completed another {_timer} seconds for the {_activityName}.");
        PauseAnimation();
    }
    public void SetTimer() {
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int timer = int.Parse(Console.ReadLine());
        _timer = timer;
    }

    
    public void PauseAnimation(int duration = 5) {
        List<string> animationStrings = new()
        {
            "/",
            "–",
            "\\",
            "|",
        };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(250);
            Console.Write($"\b \b");

            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }
    public void Countdown(int countStart = 3) {
        for (int i = countStart; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write($"\b \b");
        }
    }
    public void GetActivityCount() {
        Console.WriteLine($"(Times done: {_activityCounter})");
    }
}