public class BreathingActivity : Activity
{

    public BreathingActivity() : base()
    {
        _activityName = "Breathing Activity";
        _description = "\nThis activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _timer = 0;
    }
    
    public void RunBreathingActivity() {
        
        DisplayMessage();
        SetTimer();
        Console.WriteLine("Get Ready...");
        PauseAnimation();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timer);
        do
        {
            Console.Write("\n\nBreath in...");
            Countdown(4);
            Console.Write("\nNow breath out...");
            Countdown(6);
        } while (DateTime.Now < endTime);
        

        Console.WriteLine("\nWell done!!");
        PauseAnimation(3);

        DisplayEndMessage();
    }
}