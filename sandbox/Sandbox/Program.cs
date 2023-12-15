using System;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo myTI = new CultureInfo("en-US",false).TextInfo;

        Console.WriteLine("---Epic Name Generator---\n\nWhat is your name? ");
        string name = Console.ReadLine().ToLower();

        List<char> nameAsList = name.ToList();

        nameAsList.Sort();

        string newName = "";

        foreach (char c in nameAsList)
        {
            newName = $"{newName}{c}";
        }        

        Console.WriteLine($"\nYour new epic name is: {myTI.ToTitleCase(newName)}");
    }
}