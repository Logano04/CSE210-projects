class Cycling : Activity
{
    private int speed;
    public Cycling(string actDate, int actLength, int actSpeed)
    {
        date = actDate;
        length = actLength;
        speed = actSpeed;
    }
    public override double returnDistance()
    {
        return (length / 60.0)*speed;
    }
    public override double returnSpeed()
    {
        return speed;
    }
    public override double returnPace()
    {
        return length / returnDistance();
    }
    public override void printSummary()
    {
        Console.WriteLine($"{date} Cycling - Distance: {returnDistance()} miles, Speed: {returnSpeed()} mph, Pace: {returnPace()} minutes per mile");
    }
}