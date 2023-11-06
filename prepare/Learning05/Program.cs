using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("red", 5);
        Rectangle rectangle = new("orange", 10, 5);
        Circle circle = new("blue", 2.5);

        List<Shape> shapes = new()
        {
            square,
            rectangle,
            circle
        };

        Console.WriteLine("Shapes:");

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"Color: {s.GetColor()}\tArea: {s.GetArea()}");
            
        }


        
    }
}