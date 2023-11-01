public class ListingActivity : Activity
{
    private List<string> _prompts;
    private int _counter;

    public ListingActivity(string name, string description, int timer, List<string> prompts) : base(name, description, timer)
    {
        _prompts = prompts;
        _counter = 0;
    }

    public void RunListingActivity() {}
    public string GetRandomPrompt() {
        return "";
    }
    public int CountAnswers() {
        return 0;
    }
    public void DisplayPrompt() {}

}