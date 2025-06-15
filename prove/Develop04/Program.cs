using System;

class Program
{
    static BreathingActivity BreathingActivity = new BreathingActivity();
    static ReflectingActivity ReflectingActivity = new ReflectingActivity();
    static ListingActivity ListingActivity = new ListingActivity();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        ListingActivity.run();
    }
}