public class BreathingActivity : Activity
{
    private string activityName = "Breathing";
    private string activityDescription = "This activity will help you relax by controlling your breathing.";

    public BreathingActivity() : base("Breathing", "This activity will help you relax by controlling your breathing.")
    {
    }

    public void run()
    {
        startMessage(activityName, activityDescription);
        countdown(3);
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(_activityDuration);

        while (DateTime.Now < endTime)
        {

            Console.WriteLine("Breathe in...");
            countdown(5);
            Console.WriteLine("Breathe out...");
            countdown(5);
        }
        endMessage();
    }
}