public class Scripture
{
    static Dictionary<string, string> scriptures = new Dictionary<string, string>();
    static List<string> verseList = new List<string>();
    static void createVerseList(string verseString)
    {
        verseList = verseString.Split(" ").ToList();
    }
    static void Main()
    {
        scriptures["Jacob 6:12"] = "O be wise; what can I say more?";
        
    }
}