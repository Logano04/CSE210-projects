public class Entry
{
    public static List<string> prompts = new List<string> {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };
    public string Prompt { get; set; }
    public static string RandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        string prompt = prompts[index];
        return prompt;
    }
    public static (DateTime date, string prompt, string entry) NewEntry()
    {
        DateTime date = DateTime.Now;
        string prompt = RandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string entry = Console.ReadLine();
        return (date, prompt, entry);
    }
}