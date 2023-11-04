using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
    BreathingActivity breathingActivity = new();
    Menu menu = new();

    Console.Clear();
    Console.WriteLine("Welcome to the Mindfulness Program!\n");
    int option;
    do {
        option = menu.DisplayMenu();
    
        if (option == 1)
        {
            breathingActivity.RunBreathingActivity();
            Console.Clear();
        }
        else if (option == 2)
        {
            
            Console.Clear();
        }
        else if (option == 3)
        {
            
            Console.Clear();
        }
    } while (option != 4);
    
    Console.Clear();
    Console.WriteLine("Goodbye! Exiting program...");
    }
}