public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "Simple Goal";
    }

    public override int RecordEvent()
    {
        return -1;
    }
    public override bool isComplete()
    {
        return false;
    }
}