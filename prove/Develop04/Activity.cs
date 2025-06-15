public class Activity
{
    private string _activityName;
    private string _activityDescription;
    public int _activityDuration;

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public void startMessage(string activityName, string activityDescription)
    {
        Console.WriteLine($"Welcome to the {activityName} activity!");
        Console.WriteLine(activityDescription);
        Console.WriteLine("How long would you like the activity to last? (in seconds): ");
        _activityDuration = int.Parse(Console.ReadLine());
    }

    public void endMessage()
    {
        Console.WriteLine("Well done!");
    }

    public void countdown(int duration)
    {
        while (duration > 0)
        {
            Console.Write(duration);
            Thread.Sleep(1000);
            duration -= 1;
            Console.Write("\b");
        }
    }

    public void spinner(int duration)
    {
        string spinnerString = "-\\|/";
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);

        int index = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinnerString[index++ % spinnerString.Length]);
            Thread.Sleep(100);
            Console.Write("\b");
        }
    }
}