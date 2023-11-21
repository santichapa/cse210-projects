public class EternalGoal : Goal
{
    // private DateTime _completionDate;

    public EternalGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "EternalGoal";
        _goalCount = 0;
    }

    public override int RecordEvent()
    {
        _goalCount++;

        return _pointsValue;
    }
    // public override bool isComplete(){
    //     return _isComplete;
    // }
}