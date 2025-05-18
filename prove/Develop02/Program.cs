using System;

class Program
{
    public Entry entry = new Entry();
    public Journal journal = new Journal();

    static (DateTime, string, string) currentEntry = (DateTime.MinValue, "", "");

    static void MenuSelect(int input)
    {

        switch (input)
        {
            case 1:
                Console.WriteLine("Option 1");
                currentEntry = Entry.NewEntry();
                break;
            case 2:
                Console.WriteLine("Option 2");
                break;
            case 3:
                Console.WriteLine("Option 3");
                break;
            case 4:
                Console.WriteLine("Option 4");
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("1. Write new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Quit");
        int userInput = int.Parse(Console.ReadLine());
        MenuSelect(userInput);
    }
}