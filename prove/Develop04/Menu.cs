public class Menu
{

    public int DisplayMenu() {
        Console.WriteLine("Main menu \n1. Start Breathing Activity \n2. Start Reflecting Activity \n3. Start Listing Activity \n4. Quit");
        Console.Write("Please select one option: ");
        
        return int.Parse(Console.ReadLine());
    }
}