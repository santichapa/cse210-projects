using System.Dynamic;
using System.Xml.Serialization;
using System.IO;

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
        int goalCount = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus amount? ");
        Console.Write("> ");
        int bonusPoints = int.Parse(Console.ReadLine());

        ChecklistGoal newGoal = new(goalName, goalDescription, pointsValue, goalCount, bonusPoints);
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
    public void SaveToFile()
    {
        string filename = "goals.txt";

        Console.WriteLine("Saving to file... ");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalPoints}||{_maxPoints}||{_level}");
            foreach (Goal g in _goalList)
            {
                if (g.GetGoalType() == "SimpleGoal")
                {
                    outputFile.WriteLine($"{g.GetGoalType()}||{g.GetGoalName()}||{g.GetDescription()}||{g.GetPoints()}||{g.isComplete()}||{g.GetGoalCount()}");
                }
                else if (g.GetGoalType() == "EternalGoal")
                {
                    outputFile.WriteLine($"{g.GetGoalType()}||{g.GetGoalName()}||{g.GetDescription()}||{g.GetPoints()}");
                }
                else if(g.GetGoalType() == "ChecklistGoal")
                {
                    outputFile.WriteLine($"{g.GetGoalType()}||{g.GetGoalName()}||{g.GetDescription()}||{g.GetPoints()}||{g.isComplete()}||{g.GetGoalCount()}||{g.GetFinalGoal()}||{g.GetBouns()}");
                }
                
            }
        }
        Console.WriteLine("Done! press Enter to return to the menu.");
    }
    public void LoadFromFile()
    {
        Console.WriteLine("Loading from file...");
        string filename = "goals.txt";
        
        string[] lines = File.ReadAllLines(filename);
        

        string[] levelParts = lines[0].Split("||");

        _totalPoints = int.Parse(levelParts[0]);
        _maxPoints = int.Parse(levelParts[1]);
        _level = int.Parse(levelParts[2]);
    
        
        lines = lines.Where((val, idx) => idx != 0).ToArray();

        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            string goalType = parts[0];
            string goalName = parts[1];
            string goalDescription = parts[2];
            int pointsValue = int.Parse(parts[3]);
            bool isComplete = bool.Parse(parts[4]);
            int goalCount = int.Parse(parts[5]);

            if (goalType == "SimpleGoal")
            {
                SimpleGoal newGoal = new(goalType, goalName, goalDescription, pointsValue, isComplete, goalCount);
                _goalList.Add(newGoal);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal newGoal = new(goalName, goalDescription, pointsValue);
                _goalList.Add(newGoal);
            }
            else if (goalType == "ChecklistGoal")
            {
                int bonusPoints = int.Parse(parts[7]);
                int finalGoal = int.Parse(parts[6]);
                ChecklistGoal newGoal = new(goalType, goalName, goalDescription, pointsValue, isComplete, goalCount, finalGoal, bonusPoints);
                _goalList.Add(newGoal);
            }
        }
        Console.WriteLine("Done! press Enter to return to the menu.");
    }

}