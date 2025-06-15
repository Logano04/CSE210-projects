using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment writing = new WritingAssignment("Bob", "Gender studies", "");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}