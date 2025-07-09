public class EternalGoal : Goal
{
    private int timesCompleted = 0;

    public override void createGoal()
    {
        Console.WriteLine("What is the name of your goal?:");
        goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal:");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?:");
        pointAmount = int.Parse(Console.ReadLine());
    }
    public override int recordEvent()
    {
        if (completed == true)
        {
            return 0;
        }
        else
        {
            timesCompleted++;
            return pointAmount;
        }
    }
    public override void printStatus()
    {
        if (completed == true)
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }
        Console.Write($"{goalName} ");
        Console.Write($"{goalDescription} ");
        Console.Write($"-- Times completed: {timesCompleted}");
        Console.WriteLine();
    }
}