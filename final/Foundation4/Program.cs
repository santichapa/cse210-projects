using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        // create exercise activities
        Running running = new("06 June 2023", 35, 3.5m);
        Cycling cycling = new("07 Nov 2023", 60, 15);
        Swimming swimming = new("02 Dec 2023", 90, 20);

        // display summaries

        Console.WriteLine(running.GetSummary());
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine(swimming.GetSummary());
    }
}