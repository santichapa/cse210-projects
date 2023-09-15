using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        string letter;
        string sign;

        if (numGrade >= 90)
        {
            letter = "A";
        }
        else if (numGrade >= 80)
        {
            letter = "B";
        }
        else if (numGrade >= 70)
        {
            letter = "C";
        }
        else if (numGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (numGrade % 10 >= 7)
        {
            sign = "+";
        }
        else if (numGrade % 10 >=3)
        {
            sign = "";
        }
        else
        {
            sign = "-";
        }

        if ((letter == "A" && (numGrade % 10 >= 7)) || (letter == "F"))
        {
            sign = "";
        }

        Console.WriteLine($"Your Grade: {letter}{sign}");

        if (numGrade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass the class. Try again and do it next time!");
        }
    }
}