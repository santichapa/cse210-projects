public class ManageInterface
{
    private int _totalPoints;
    private List<Goal> _goalList;

    public ManageInterface()
    {
        _totalPoints = 0;
        _goalList = new(); 
    }

    public void DisplayGoalList(){}
    public void DisplayGoalType(){}
    public void SaveToFile(){}
    public void LoadFromFile(){}
    public void SumPoints(int points){}
}