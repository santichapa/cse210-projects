using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected bool _isComplete;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointsValue;
    protected int _goalCount;

    public string GoalType { get; }
    public string GoalName { get; }
    public string GoalDescription { get; }
    public int PointsValue { get; }

    public Goal() {}
    public Goal(string goalName, string goalDescription, int pointsValue)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointsValue = pointsValue;
        _isComplete = false;
        _goalType = "";
        _goalCount = 0;
    }
    public Goal(string goalType, string goalName, string goalDescription, int pointsValue, bool isComplete, int goalCount)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointsValue = pointsValue;
        _isComplete = isComplete;
        _goalType = goalType;
        _goalCount = goalCount;
    }

    protected Goal(string goalType, string goalName, string goalDescription, int pointsValue)
    {
        GoalType = goalType;
        GoalName = goalName;
        GoalDescription = goalDescription;
        PointsValue = pointsValue;
    }

    public string GetGoalType(){
        return _goalType;
    }
    public string GetGoalName(){
        return _goalName;
    }
    public string GetDescription(){
        return _goalDescription;
    }
    public int GetPoints(){
        return _pointsValue;
    }
    public virtual int RecordEvent(){
        return _pointsValue;
    }
    public virtual bool isComplete() {
        return _isComplete;
    }
    public virtual int GetGoalCount()
    {
        return _goalCount;
    }

    public virtual int GetFinalGoal() {
        return 0;
    }
    public virtual int GetBouns(){
        return 0;
    }
}