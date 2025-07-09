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
            Goal.printStatus();
        }
    }
}