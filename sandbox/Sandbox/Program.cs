using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Hello Sandbox World! {i}");
        }

    //    Random randomGenerator = new Random();
    //    int randomNumber = new randomGenerator(1,100);

        List<int> myNumbers = new List<int>();
        myNumbers.Add(1);
        myNumbers.Add(23);
        myNumbers.Add(-8);

        foreach(int i in myNumbers)
        {
            Console.WriteLine(i);
        }
    }
}