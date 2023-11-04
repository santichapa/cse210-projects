public class ReflectActivity : Activity
{
    private List<string> _reflectionPrompts = new();
    private List<string> _questions = new();

    public ReflectActivity() : base()
    {
        _activityName = "Reflecting Activity";
        _description = "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        _reflectionPrompts.Add("Think of a time when you did something really difficult.");
        _reflectionPrompts.Add("Think of a time when you helped someone in need.");
        _reflectionPrompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void RunReflectActivity(){
        DisplayMessage();
        SetTimer();
        Console.WriteLine("Get Ready...");
        PauseAnimation();

        Console.WriteLine("\nConsider the following prompt: \n");
        DisplayReflectionPrompt();
        Console.Write("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        Countdown(5);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timer);
        
        Console.Clear();
        do
        {
            DisplayReflectionQuestion();
            PauseAnimation(10);  
        } while (DateTime.Now < endTime);

        Console.WriteLine("\n\nWell done!!");
        PauseAnimation(3);

        DisplayEndMessage();
        _activityCounter++;
    }
    public void DisplayReflectionPrompt() {
        Random random = new();
        int index = random.Next(0, _reflectionPrompts.Count);

        Console.Write($"––– {_reflectionPrompts[index]} –––\n");
    }
    public void DisplayReflectionQuestion() {
        Random random = new();
        int index = random.Next(0, _questions.Count);

        Console.Write($"\n> {_questions[index]} ");
    }
}