public class ReflectActivity : Activity
{
    private List<string> _reflectionPrompts;
    private List<string> _questions;

    public ReflectActivity(string name, string description, int timer, List<string> reflectionpPrompts, List<string> questions) : base(name, description, timer)
    {
        _reflectionPrompts = reflectionpPrompts;
        _questions = questions;
    }

    public void RunReflectActivity(){}
    public string GetRandomPrompt() {
        return "";
    }
    public string GetRandomQuestion() {
        return "";
    }
    public void DisplayReflectionPrompt() {}
    public void DisplayReflectionQuestion() {}
}