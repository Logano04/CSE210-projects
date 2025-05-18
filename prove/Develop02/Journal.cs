public class Journal
{
    private List<Entry> entries = new List<Entry>();
    private string _fileName;

    public Journal()
    {
    }

    public Journal(string fileName)
    {
        _fileName = fileName;
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }
}