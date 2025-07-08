public class ChecklistGoal : Goal
{
    private int bonusPoints;
    private int requiredCompletions;
    private int timesCompleted;

    public override void createGoal()
    {
        base.createGoal();
    }
    public override void recordEvent()
    {
        timesCompleted++;
        if (timesCompleted >= requiredCompletions){
            completed = true;
        }
    }
}