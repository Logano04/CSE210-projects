class Running : Activity
{
    private int distance;

    public Running(string actDate, int actLength, int actDistance)
    {
        date = actDate;
        length = actLength;
        distance = actDistance;
    }
    public override double returnDistance()
    {
        return distance;
    }
    public override double returnSpeed()
    {
        return distance / (length/60.0);
    }
    public override double returnPace()
    {
        return length / returnDistance();
    }
    public override void printSummary()
    {
        Console.WriteLine($"{date} Running - Distance: {returnDistance()} miles, Speed: {returnSpeed()} mph, Pace: {returnPace()} minutes per mile");
    }
}