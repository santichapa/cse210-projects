using System.IO;
public class Journal
{
    public List<Entry> Entries = new();
    public string _fileName;

    public void DisplayEntries() {
        foreach (Entry e in Entries)
        {
            Console.WriteLine($"{e._date} - {e._prompt}\n{e._answer}\n");
        }
    }

    public void LoadFromFile() {
        Console.Write("Please insert the filename: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Reading from file...");
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            Entry newEntry = new();
            newEntry._answer = parts[2];
            newEntry._date = parts[0];
            newEntry._prompt = parts[1];

            Entries.Add(newEntry);
        }
    }

    public void SaveToFile() {
        Console.Write("Please insert the filename: ");
        string fileName = Console.ReadLine();

        Console.WriteLine("Saving to file...");
        using(StreamWriter outputfile = File.AppendText(fileName))
        {
            foreach (Entry e in Entries)
            {
                outputfile.WriteLine($"{e._date}||{e._prompt}||{e._answer}");
            }
        }

    }
}