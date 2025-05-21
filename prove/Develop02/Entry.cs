public class Entry
{
    public static List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };
    public string Prompt;

    public string Date;

    public string EntryText;
    public static string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public void NewEntry()
    {
        DateTime date = DateTime.Now;
        Date = date.ToString("dddd MM dd yyyy");
        Prompt = RandomPrompt();
        Console.WriteLine(Prompt);
        Console.Write("> ");
        EntryText = Console.ReadLine();
    }
}