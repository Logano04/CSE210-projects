using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        Console.Write("Please enter your name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine($"Your first name is {firstName}.");

        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your last name is {lastName}.");
    }
}