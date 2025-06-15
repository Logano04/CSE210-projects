using System;
public class ListingActivity : Activity
{
    private string activityName = "Listing";
    private string activityDescription = "This activity will help you reflect on the good things in your life.";
    private string[] prompts = { "How have you felt the Holy Ghost this month?", "bruh" };
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life.")
    {
    }

    public void run()
    {
        startMessage(activityName, activityDescription);
        Console.WriteLine("Get ready...");
        countdown(3);
        Console.WriteLine("List as many response as you can to the following prompt: ");
        Random rand = new Random();
        int randomIndex = rand.Next(prompts.Length);
        Console.WriteLine(prompts[randomIndex]);
        Console.WriteLine("You may begin in...");
        countdown(3);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
        }
        endMessage();
    }
}