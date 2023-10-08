using System;
using System.Diagnostics.Contracts;
using System.Security.Cryptography;

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
            Console.WriteLine("\nPlease select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Edit entries \n6. Quit");
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
                journal.DisplayEntries(true);
                journal.EditEntry();
            }
            else if (selectedNum == 6) {
                repeat = false;
            }
        };
    }
}

// To exceed requirements, I created a new option for the user to edit an entry. Then, the entry is stored in the program and can be saved to a file normally.