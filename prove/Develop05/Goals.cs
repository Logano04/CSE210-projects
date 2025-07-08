public class Goals
{
    Goal goal = new Goal();

    List<Goal> goalsList = new List<Goal>();
    public int points;

    public void addGoal(Goal goal)
    {
        goalsList.Add(goal);
    }

    public void displayGoals()
    {
        foreach (Goal Goal in goalsList)
        {
            if (Goal.completed == true)
            {
                Console.Write("[X]");
            }
            else
            {
                Console.Write("[ ]");
            }
            Console.Write($"{Goal.goalName} ");
            Console.Write($"{Goal.goalDescription} ");
            Console.WriteLine();
        }
    }
}