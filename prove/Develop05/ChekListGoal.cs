using System.Security.Cryptography;

public class ChekListGoal : Goal
{
    public int _finalGoal;
    private int _bonusPoints;
    public ChekListGoal(string goalName, string goalDescription, int pointsValue, int finalGoal, int bonusPoints) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "ChecklistGoal";
        _finalGoal = finalGoal;
        _bonusPoints = bonusPoints;
    }
    // public string ChecklistProgress(){
    //     return $"-- Current progress: {_goalCount}/{_finalGoal}";
    // }
    public override int RecordEvent()
    {
        _goalCount++;
        if(_finalGoal == _goalCount && _isComplete == false)
        {
            _isComplete = true;
            Console.WriteLine("You got a bonus!");

            return _pointsValue + _bonusPoints;
        }
        else if (_goalCount > _finalGoal)
        {
            _goalCount = _finalGoal;
            return 0;
        }
        else
        {
            return _pointsValue;
        }
    }
    public override bool isComplete()
    {
        return _isComplete;
    }
    public override int GetFinalGoal()
    {
        return _finalGoal;
    }

    public override int GetBouns()
    {
        return _bonusPoints;
    }

    public override int GetGoalCount()
    {
        return _goalCount;
    }
}
