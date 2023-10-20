using System;
using System.Diagnostics.Contracts;
using System.Net.Quic;

class Program
{
    static void Main(string[] args)
    {
        string input;
        // string scriptureText = @"And when ye shall receive these things, I would exhort you that ye would aask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost.
        // And by the power of the Holy Ghost ye may know the truth of all things.";
        string scriptureText = "For behold, are we not all abeggars? Do we not all depend upon the same Being, even God, for all the substance which we have, for both food and raiment, and for gold, and for silver, and for all the riches which we have of every kind?";
        
        // Reference reference = new("Moroni", 10, 4, 5);
        Reference reference = new("Mosiah", 4, 19);

        Scripture scripture = new(reference, scriptureText);
        do
        {
            Console.Clear();
            Console.WriteLine($"{reference.RenderReference()} {scripture.GetRenderedText()}");
            Console.Write("\nPress Enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

            if (scripture.IsCompletelyHidden() == false)
            {
                // you can change the number of words that hide at a time
                scripture.HideWords();
                scripture.HideWords();
                scripture.HideWords();
            }
            else 
            {
                input = "quit";
            }
            
        } while (input.ToLower() != "quit");
    }
}