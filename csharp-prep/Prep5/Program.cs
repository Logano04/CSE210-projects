using System;

class Program
{
    static void DisplayGreeting()
    {
        Console.WriteLine("Hello, welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number?: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        return number * number;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"Hello {name}, your number squared is {squaredNumber}.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayGreeting();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, SquareNumber(number));
    }
}