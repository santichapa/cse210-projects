using System;

class Program
{
    static void Main(string[] args)
    {
        int newNumber;
        List<int> numbersList = new List<int>();
        int sum = 0;
        int max = -1;
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter Number: ");
            newNumber = int.Parse(Console.ReadLine());
            numbersList.Add(newNumber);
        }
        while (newNumber != 0);

        foreach (int number in numbersList)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {sum/numbersList.Count}");
        Console.WriteLine($"The largest number is: {max}");
    }
}