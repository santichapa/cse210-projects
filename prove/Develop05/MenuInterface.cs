using System.Dynamic;
using System.Xml.Serialization;

public class MenuInterface
{
    private int _level;
    private int _maxPoints;
    private int _totalPoints;
    private List<Goal> _goalList = new();

    public MenuInterface()
    {
        _level = 1;
        _totalPoints = 0;
        _maxPoints = 100;
    }

    public void DisplayMenu(){
        LevelUp();
        // SumPoints();
        Console.Write($"You have {_totalPoints}/{_maxPoints} EXP || Level {_level} \n--Main Menu--\n\nOptions:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
    }
    public int SelectGoalType(){
        Console.Write("\nThe types of goals are: \n  1. Simple Goal\n  2. Eternal Goal\n  3. Cheklist Goal\nWhat type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
    public void SaveNewGoal(int choice){
        Console.WriteLine("Whats the name of your goal? ");
        Console.Write("> ");
        string goalName = Console.ReadLine();

        Console.WriteLine("Please write a short description of your goal: ");
        Console.Write("> ");
        string goalDescription = Console.ReadLine();

        Console.WriteLine("What is the amount of points associated to your goal? ");
        Console.Write("> ");
        int pointsValue = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            SimpleGoal newGoal = new(goalName, goalDescription, pointsValue);
            _goalList.Add(newGoal);
        }
        else if (choice == 2)
        {
            EternalGoal newGoal = new(goalName, goalDescription, pointsValue);
            _goalList.Add(newGoal);
        }
        else if (choice == 3)
        {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        Console.Write("> ");
        int goalcount = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus amount? ");
        Console.Write("> ");
        int bonusPoints = int.Parse(Console.ReadLine());

        ChekListGoal newGoal = new(goalName, goalDescription, pointsValue, goalcount, bonusPoints);
        _goalList.Add(newGoal);
        }
    }
    public void DisplayGoalList(){
        int index = 0;

        foreach (Goal g in _goalList)
        {
            
            string goal = $"> {g.GetGoalName()}: {g.GetDescription()} ({g.GetPoints()})";
            if (g.GetGoalType() == "ChecklistGoal")
                {
                    goal += $" {g.GetGoalCount()}/{g.GetFinalGoal()}"; 
                }

            if(g.isComplete())
            {
                Console.WriteLine($"[X] {goal}");
            }
            else
            {
                Console.WriteLine($"[ ] {goal}"); 
            }

            
            index++;
        }
        Console.Write("\nPress Enter to return to the menu.");
    }
    // public void DisplayChecklistProgress(){
    //     foreach (ChekListGoal g in _goalList)
    //     {
    //         string goalProgress = $" {g.GetGoalCount()}/{g.GetFinalGoal()}";
    //     }

    // }
    public void UpdateGoalMenu(){
        Console.WriteLine("The goals are:");
        int index = 1;

        foreach (Goal g in _goalList)
        {
            Console.WriteLine($"{index}. {g.GetGoalName()}");
            index++;
        }
        Console.WriteLine("Which goal did you accomplish? ");
        int completedGoalIndex = int.Parse(Console.ReadLine()) -1;

        

        SumPoints(_goalList[completedGoalIndex]);
    }
    // public void SumPoints(){
    //     _totalPoints = 0;
        
    //     foreach (Goal g in _goalList)
    //     {
    //         if (g.GetGoalType() == "SimpleGoal" && g.isComplete())
    //         {
    //             _totalPoints += g.RecordEvent();
    //         }
    //         else if (g.GetGoalType() == "EternalGoal")
    //         {
    //             _totalPoints += g.GetPoints() * g.GetGoalCount();
    //         }
    //         else if (g.GetGoalType() == "ChecklistGoal")
    //         {
    //             _totalPoints += g.GetPoints() * g.GetGoalCount() + g.RecordEvent();
    //         }
    //     }   
    // }
    public void SumPoints(Goal goal)
    {
        int points = goal.RecordEvent();
        Console.WriteLine($"You won {points} points! \npress Enter to continue...");
        Console.ReadLine();
        _totalPoints += points;
    }
    public void LevelUp(){
        while (_totalPoints >= _maxPoints)
        {
            _maxPoints *= 2;
            _level++;
        }
    }
    public void SaveToFile(){}
    public void LoadFromFile(){}

}