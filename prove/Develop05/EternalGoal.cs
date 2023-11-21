public class EternalGoal : Goal
{
    // private DateTime _completionDate;

    public EternalGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "EternalGoal";
        _goalCount = 0;
    }

    public EternalGoal(string goalType, string goalName, string goalDescription, int pointsValue, bool isComplete, int goalCount) : base(goalType, goalName, goalDescription, pointsValue, isComplete, goalCount){}


    public override int RecordEvent()
    {
        _goalCount++;

        return _pointsValue;
    }
    // public override bool isComplete(){
    //     return _isComplete;
    // }
}