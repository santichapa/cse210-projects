public class Menu
{

    public int DisplayMenu() {
        Console.WriteLine("Main menu \n1. Breathing Activity \n2. Reflect Activity \n3. Listing Activity \n4. quit");
        Console.Write("Please select one option: ");
        
        return int.Parse(Console.ReadLine());
    }
}