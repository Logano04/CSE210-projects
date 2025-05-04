using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");

        List<int> numbersList = new List<int>();

        Console.Write("Enter a number to add it to the list, enter 0 when finished: ");
        int userInput = int.Parse(Console.ReadLine());
        numbersList.Add(userInput);

        while (userInput != 0)
        {
            Console.Write("Enter number: ");
            userInput = int.Parse(Console.ReadLine());
            numbersList.Add(userInput);
        }      

        for (int i = 0; i < numbersList.Count; i++)
        {
            Console.Write($"{numbersList[i]}, ");
        }
        Console.WriteLine();

        Console.WriteLine($"The sum is: {numbersList.Sum()}");
        Console.WriteLine($"The average is: {numbersList.Average()}");
        Console.WriteLine($"The largest number is: {numbersList.Max()}");
        
    }
}