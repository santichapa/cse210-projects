using System.Reflection.Metadata.Ecma335;

public abstract class Goal
{
    protected bool _isComplete;
    protected string _goalName;
    protected string _goalDescription;
    protected int _pointsValue;
    protected string _goalType;

    public Goal(string goalName, string goalDescription, int pointsValue)
    {
        _goalName = goalName;
        _goalDescription = goalDescription;
        _pointsValue = pointsValue;
        _isComplete = false;
        _goalType = "";
    }

    public void SetGoalType(){}
    public string GetGoalType(){
        return "";
    }
    public void SetGoal(){}
    public string GetGoal(){
        return "";
    }
    public void SetDescription(){}
    public string GetDescription(){
        return "";
    }
    public void SetPoints(){}
    public string GetPoints(){
        return "";
    }
    public virtual int RecordEvent(){
        return -1;
    }
    public virtual bool isComplete() {
        return false;
    }
}