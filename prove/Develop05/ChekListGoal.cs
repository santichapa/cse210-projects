using System.Security.Cryptography;

public class ChekListGoal : Goal
{
    private int _bonusPoints;
    public ChekListGoal(string goalName, string goalDescription, int pointsValue) : base(goalName, goalDescription, pointsValue)
    {
        _goalType = "ChekList Goal";
    }

    public void SetBonus(){}
    public int GetBonus(){
        return -1;
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