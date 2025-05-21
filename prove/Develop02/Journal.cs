using System.IO; 
public class Journal
{
    public List<Entry> entries = new List<Entry>();

    public string fileName = "";

    public void WriteFile()
    {
        Console.WriteLine("What is the name of the file you want to write to?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.Date);
                outputFile.WriteLine(entry.Prompt);
                outputFile.WriteLine(entry.EntryText);
            }
        }
    }

    public void ReadFile()
    {
        Console.WriteLine("What is the name of the file you want to read from?");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);
        int index = 0;
        Entry entry = new Entry();

        foreach (string line in lines)
        {
            if (index % 3 == 0)
            {
                entry.Date = lines[index];
                entry.Prompt = lines[index + 1];
                entry.EntryText = lines[index + 2];
                entries.Add(entry);
            }
            index++;
        }
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date} - {entry.Prompt}");
            Console.WriteLine(entry.EntryText);
            Console.WriteLine();
        }
    }
}