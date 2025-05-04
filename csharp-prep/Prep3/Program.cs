using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //Console.WriteLine("Hello Prep3 World!");
        Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        int currentGuess = int.Parse(Console.ReadLine());
        int guessCount = 1;

        while (currentGuess != magicNumber)
        {
            guessCount++;
            if (currentGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            currentGuess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine($"Congratulations! You guessed the magic number in {guessCount} guesses!");
    }
}