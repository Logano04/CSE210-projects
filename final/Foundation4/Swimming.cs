class Swimming : Activity
{
    private int lapCount;

    public Swimming(string actDate, int actLength, int actLapCount)
    {
        date = actDate;
        length = actLength;
        lapCount = actLapCount;
    }
    public override double returnDistance()
    {
        return lapCount * 50 / (1000*0.62);
    }
    public override double returnSpeed()
    {
        return (lapCount * 50 / (1000*0.62)) / (length/60.0);
    }
    public override double returnPace()
    {
        return length / returnDistance();
    }
    public override void printSummary()
    {
        Console.WriteLine($"{date} Swimming - Distance: {returnDistance()} miles, Speed: {returnSpeed()} mph, Pace: {returnPace()} minutes per mile");
    }
}