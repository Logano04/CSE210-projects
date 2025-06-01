using System;

class Program
{
    static bool MenuSelect(string input)
    {
        if (input == "q")
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    static void Main(string[] args)
    {
        Word word = new Word();

        bool keepGoing = true;

        while (keepGoing)
        {
            string userInput = "";
            keepGoing = MenuSelect(userInput);
        }
    }
}