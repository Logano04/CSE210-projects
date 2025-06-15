using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("hsjkwsdhgvjah");
        int sleepTime = 250;

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(20);

        int count = 9;

        while (DateTime.Now < endTime) 
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            Console.Write("\b");
        }

        string animationString2 = "-+\\|/";
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString2[index++ % animationString2.Length]);
            Thread.Sleep(sleepTime);
            Console.Write("\b");
        }

        
        string animationString = "(^o^)(-_-)";
        
        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
    }
}