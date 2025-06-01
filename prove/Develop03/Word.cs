public class Word
{
    private bool hidden = false;

    public string hideWord(string word)
    {
        List<char> letters = new List<char> { };
        foreach (char letter in word)
        {
            letters.Add('_');
        }
        string hiddenWord = new string(letters.ToArray());
        return hiddenWord;
    }
}