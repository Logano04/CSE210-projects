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
    public void listGoals()
    {
        //list goals for recordEvent selection
        int goalIndex = 1;
        foreach (Goal Goal in goalsList)
        {
            Console.Write($"{goalIndex}. {Goal.goalName}, {Goal.goalDescription}");
            goalIndex++;
        }
        int goalSelection = int.Parse(Console.ReadLine());
        goalSelection--;
        Goal recordingGoal = goalsList[goalSelection];
        recordingGoal.recordEvent();
        }
}