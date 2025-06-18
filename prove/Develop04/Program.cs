using System;

class Program
{
    static BreathingActivity BreathingActivity = new BreathingActivity();
    static ReflectingActivity ReflectingActivity = new ReflectingActivity();
    static ListingActivity ListingActivity = new ListingActivity();

    static bool MenuSelect(int selection)
    {
        switch (selection)
        {
            case 1:
                BreathingActivity.run();
                break;
            case 2:
                ReflectingActivity.run();
                break;
            case 3:
                ListingActivity.run();
                break;
            case 5:
                return false;
        }
        return true;
    }
    static void Main(string[] args)
    {
        bool keepGoing = true;
        while (keepGoing)
        {
            Console.WriteLine("Select Activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            int userInput = int.Parse(Console.ReadLine());
            keepGoing = MenuSelect(userInput);
        }
    }
}