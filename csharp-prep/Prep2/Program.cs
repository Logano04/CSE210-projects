using System;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("What is your grade percentage?");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "F";

        if (grade >= 90)
        {
            letterGrade = "A";
            Console.WriteLine($"You got an {letterGrade}");
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            Console.WriteLine($"You got a {letterGrade}");
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            Console.WriteLine($"You got a {letterGrade}");
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            Console.WriteLine($"You got a {letterGrade}");
        }
        else
        {
            letterGrade = "F";

            Console.WriteLine($"You got an {letterGrade}");
        }

        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else
        {
            Console.WriteLine("You failed the class.");
        }
    }
}