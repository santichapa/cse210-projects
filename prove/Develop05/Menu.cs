public class Menu
{
    public Menu(){}
    public void DisplayMenu(){
        Console.Write("\n--Main Menu--\n\nOptions:\n  1. Create New Goal\n  2. List Goals\n  3. Save Goals\n  4. Load Goals\n  5. Record Event\n  6. Quit\nSelect a choice from the menu: ");
    }
    public int SelectGoalType(){
        Console.Write("\nThe types of goals are: \n  1. Simple Goal\n  2. Eternal Goal\n  3. Cheklist Goal\nWhat type of goal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        return choice;
    }
}