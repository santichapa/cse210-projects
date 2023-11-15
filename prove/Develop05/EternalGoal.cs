public class EternalGoal : Goal
{
    private DateTime _completionDate;

    public EternalGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "Eternal Goal";
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