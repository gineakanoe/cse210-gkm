using System.IO;

public class Journal
{
    public List<Entry> _entries;

    DateTime theCurrentTime = DateTime.Now;
    // string dateText = theCurrentTime.ToShortDateString();

    public void AddEntry(Entry _entries)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        string chosenPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(chosenPrompt);
        Console.Write("Entry: ");
        string userEntry = Console.ReadLine();

        // Entry newEntry = new Entry();
        // _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            // Console.WriteLine(entry.Display());
        }
    }

    public void SaveToFile(string file)
    {
        Console.Write("What would you like to save the file as? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_entries}");
        }
    }

    public void LoadFromFile(string file)
    {
        Console.Write("What file would you like to open? ");
        string fileName = Console.ReadLine();

        string [] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstEntry = parts[0];
            string secondEntry = parts[1];
        }
    }
}