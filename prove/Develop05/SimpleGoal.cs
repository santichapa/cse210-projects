using System.Reflection.Metadata.Ecma335;

public class SimpleGoal : Goal
{

    public SimpleGoal (){}
    public SimpleGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "SimpleGoal";
    }
    public SimpleGoal(string goalType, string goalName, string goalDescription, int pointsValue, bool isComplete, int goalCount) : base(goalType, goalName, goalDescription, pointsValue, isComplete, goalCount){}
    
    public override bool isComplete()
    {
        return _isComplete;
    }
    public override int RecordEvent()
    {
        
        _isComplete = true;
        if (_goalCount == 0)
        {
            _goalCount++;
            return _pointsValue;
        }
        else
        {
            return 0;
        }
        
    }
}