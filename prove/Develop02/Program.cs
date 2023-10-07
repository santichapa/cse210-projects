using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new();
        Entry entry = new();
        PromptGenerator promptGenerator = new(); 
        
        bool repeat = true;

        Console.WriteLine("Welcome to your Virtual Journal!");
        while (repeat) {
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
            Console.Write("What would you like to do? ");
            int selectedNum = int.Parse(Console.ReadLine());
    
            if (selectedNum == 1) {
                string randomPrompt = promptGenerator.GenerateRandomPrompt();
                Console.WriteLine(randomPrompt);
                
                journal.Entries.Add(entry.GenerateNewEntry(randomPrompt));
            }
            else if (selectedNum == 2) {
                journal.DisplayEntries();
            }
            else if (selectedNum == 3) {
                journal.LoadFromFile();
            }
            else if (selectedNum == 4) {
                journal.SaveToFile();
            }
            else if (selectedNum == 5) {
                repeat = false;
            }
        };
    }
}