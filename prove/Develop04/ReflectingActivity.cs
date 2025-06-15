using System;
public class ReflectingActivity : Activity
{
    private string activityName = "Reflecting";
    private string activityDescription = "This activity will help you reflect on times in your life where you have showed strength or resiliance";
    private string[] prompts = { "> How did you feel when it was complete? ", "> What was your favorite thing about this experience? ", "> What did you learn from it? ", "> What was your least favorite thing about this experience? ", "> Would you do this again if given the chance? " };


    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life where you have showed strength or resiliance")
    {

    }

    public void run()
    {
        startMessage(activityName, activityDescription);
        spinner(3);
        Console.WriteLine("-- Think of a time you have done something especially difficult --");
        Console.WriteLine("When you have something in mind, press enter.");
        Console.ReadLine();
        Random rand = new Random();
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);
        while (DateTime.Now < endTime)
        {
            int randomIndex = rand.Next(prompts.Length);
            Console.WriteLine(prompts[randomIndex]);
            spinner(5);
        }
        endMessage();
    }
}