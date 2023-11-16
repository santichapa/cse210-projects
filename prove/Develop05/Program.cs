using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new(){};

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
                            Console.WriteLine("simple goal");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("eternal goal");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("checklist goal");
                            Console.ReadLine();
                            break;
                        default:

                            break;
                    }
                    break;
                case 2: // List goals
                    Console.Clear();
                    Console.WriteLine("2");
                    Console.ReadLine();
                    break;
                case 3: // Save goals to a file
                    Console.Clear();
                    Console.WriteLine("3");
                    Console.ReadLine();
                    break;
                case 4: // Load goals from a file
                    Console.Clear();
                    Console.WriteLine("4");
                    Console.ReadLine();
                    break;
                case 5: // Record event
                    Console.Clear();
                    Console.WriteLine("5");
                    Console.ReadLine();
                    break;
            }
        } while (userInput != 6);
        
        

        
    }
}