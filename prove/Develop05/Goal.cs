public class Goal
{
    public string goalName;
    public string goalDescription;
    public int pointAmount;
    public bool completed = false;

    public virtual void createGoal()
    {
        Console.WriteLine("What is the name of your goal?:");
        goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal:");
        goalDescription = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?:");
        pointAmount = int.Parse(Console.ReadLine());
    }

    public virtual void recordEvent()
    {
        completed = true;
    }

    public void saveGoal()
    {
        
    }
}