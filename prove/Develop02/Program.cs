using System;

class Program
{
    static bool MenuSelect(int input, Journal journal)
    {
        switch (input)
        {
            case 1:
                Entry entry = new Entry();
                entry.NewEntry();
                journal.entries.Add(entry);
                break;
            case 2:
                journal.DisplayJournal();
                break;
            case 3:
                journal.WriteFile();
                break;
            case 4:
                journal.ReadFile();
                break;
            case 5:
                Console.WriteLine("Option 5");
                return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        Journal journal = new Journal(); 
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("Hello Develop02 World!");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            int userInput = int.Parse(Console.ReadLine());
            keepGoing = MenuSelect(userInput, journal);
        }
    }
}