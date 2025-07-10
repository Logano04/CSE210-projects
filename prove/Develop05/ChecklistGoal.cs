public class ChecklistGoal : Goal
{
    private int bonusPoints;
    private int requiredCompletions;
    private int timesCompleted;
    public new string goalType = "ChecklistGoal";

    public override void createGoal()
    {
        Console.WriteLine("What is the name of your goal?:");
        goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal:");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?:");
        pointAmount = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times must this goal be completed to receive a bonus?");
        requiredCompletions = int.Parse(Console.ReadLine());
        Console.WriteLine("what is the bonus point amount?");
        bonusPoints = int.Parse(Console.ReadLine());
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
            if (timesCompleted >= requiredCompletions)
            {
                completed = true;
                return bonusPoints;
            }
            else
            {
                return pointAmount;
            }
        }
    }
    public override void printStatus()
    {
        if (completed == true)
        {
            Console.Write("[X] - ");
        }
        else
        {
            Console.Write("[ ] - ");
        }
        Console.Write($"{goalName}: ");
        Console.Write($"{goalDescription} ");
        Console.Write($"-- Currently completed: {timesCompleted}/{requiredCompletions}");
        Console.WriteLine();
    }
    public override string getStringInfo()
    {
        string info = $"{goalType}:{goalName}&{goalDescription}&{pointAmount}&{completed}&{bonusPoints}&{requiredCompletions}&{timesCompleted}";
        return info;
    }
}