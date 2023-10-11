using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    Fraction fraction = new(1);
    Fraction fraction2 = new(5);
    Fraction fraction3 = new(3, 4);
    Fraction fraction4 = new(1, 3);

    Console.WriteLine(fraction.GetFractionString());
    Console.WriteLine(fraction.GetDecimalValue());

    Console.WriteLine(fraction2.GetFractionString());
    Console.WriteLine(fraction2.GetDecimalValue());

    Console.WriteLine(fraction3.GetFractionString());
    Console.WriteLine(fraction3.GetDecimalValue());

    Console.WriteLine(fraction4.GetFractionString());
    Console.WriteLine(fraction4.GetDecimalValue());




    } 
}