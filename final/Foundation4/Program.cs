class Program
{
    static void Main(string[] args)
    {
        List<Activity> activitiesList = new List<Activity>();
        Running running = new Running("6-17, 2025", 60, 8);
        activitiesList.Add(running);
        Cycling cycling = new Cycling("4-15, 2025", 30, 15);
        activitiesList.Add(cycling);
        Swimming swimming = new Swimming("7-19, 2025", 20, 40);
        activitiesList.Add(swimming);

        foreach (Activity activity in activitiesList)
        {
            activity.printSummary();
        }
    }
}