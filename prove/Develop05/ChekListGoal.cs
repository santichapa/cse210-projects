using System.Security.Cryptography;

public class ChecklistGoal : Goal
{
    public int _finalGoal;
    private int _bonusPoints;
    public ChecklistGoal(string goalName, string goalDescription, int pointsValue, int finalGoal, int bonusPoints) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "ChecklistGoal";
        _finalGoal = finalGoal;
        _bonusPoints = bonusPoints;
    }
    public ChecklistGoal(string goalType, string goalName, string goalDescription, int pointsValue, bool isComplete, int goalCount, int finalGoal, int bonusPoints) : base(goalType, goalName, goalDescription, pointsValue, isComplete, goalCount)
    {
        _finalGoal = finalGoal;
        _bonusPoints = bonusPoints;
    }

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
