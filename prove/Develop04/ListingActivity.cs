public class ListingActivity : Activity
{
    private List<string> _prompts = new();
    private int _counter;

    public ListingActivity() : base()
    {
        _activityName = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
        _counter = 0;
    }

    public void RunListingActivity() {
        _counter = 0;
        DisplayMessage();
        SetTimer();
        Console.WriteLine("Get Ready...");
        PauseAnimation();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        DisplayPrompt();

        Console.Write("You may begin in: ");
        Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timer);
        
        Console.WriteLine();
        do
        {
            Console.Write("> ");
            Console.ReadLine();
            _counter++;
        } while (DateTime.Now < endTime);
        Console.WriteLine($"You listed {_counter} items!");

        Console.WriteLine("\nWell done!!");
        PauseAnimation(3);

        DisplayEndMessage();
        _activityCounter++;
    }
    public string GetRandomPrompt() {
        Random random = new();
        int index = random.Next(0, _prompts.Count);
        return $" ––– {_prompts[index]} ––– ";
        
    }
    public void DisplayPrompt() {
        Console.WriteLine(GetRandomPrompt());
    }

}