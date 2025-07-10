using System.IO;
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
            Console.Write($"{goalIndex}. {Goal.goalName}: {Goal.goalDescription} ");
            goalIndex++;
        }
        Console.WriteLine();
        int goalSelection = int.Parse(Console.ReadLine());
        goalSelection--;
        Goal recordingGoal = goalsList[goalSelection];
        points += recordingGoal.recordEvent();
    }

    public void printPoints()
    {
        Console.WriteLine($"Points: {points}");
    }

    public void WriteFile()
    {
        Console.WriteLine("What is the name of the file you want to write to?");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(points);
            foreach (Goal goal in goalsList)
            {
                string goalInfo = goal.getStringInfo();
                outputFile.WriteLine(goalInfo);
            }
        }
    }
    public void ReadFile()
    {
        Console.WriteLine("What is the name of the file you want to read from?");
        string filename = Console.ReadLine();
        {
            string firstLine = File.ReadLines(filename).First();
            points = int.Parse(firstLine);
        }
    }
}