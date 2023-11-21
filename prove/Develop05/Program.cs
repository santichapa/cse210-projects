using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        MenuInterface menu = new();

        int userInput;
        do
        {
            Console.Clear();
            menu.DisplayMenu();

            userInput = int.Parse(Console.ReadLine());
            switch (userInput)
            {
                case 1: // Create goals
                    switch (menu.SelectGoalType())
                    {
                        case 1:
                            menu.SaveNewGoal(1);
                            break;
                        case 2:
                            menu.SaveNewGoal(2);
                            break;
                        case 3:
                            menu.SaveNewGoal(3);
                            break;
                        default:

                            break;
                    }
                    break;
                case 2: // List goals
                    Console.Clear();
                    menu.DisplayGoalList();
                    Console.ReadLine();
                    break;
                case 3: // Save goals to a file
                    Console.Clear();
                    menu.SaveToFile();
                    Console.ReadLine();
                    break;
                case 4: // Load goals from a file
                    Console.Clear();
                    menu.LoadFromFile();
                    Console.ReadLine();
                    break;
                case 5: // Record event
                    Console.Clear();
                    menu.UpdateGoalMenu();
                    break;
            }
        } while (userInput != 6);
        
        

        
    }
}