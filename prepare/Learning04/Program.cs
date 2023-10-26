using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment assignment1 = new("Brigham", "Fractions", "13", "9-12");
        WritingAssignment assignment2 = new("Mary Waters", "European History", "The Causes of World War II" );

        Console.WriteLine(assignment1.getSummary());
        Console.WriteLine(assignment1.getHomeworkList());

        Console.WriteLine(assignment2.getSummary());
        Console.WriteLine(assignment2.getWritingInfo());
    }
}