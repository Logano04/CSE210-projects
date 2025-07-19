abstract class Activity
{
    public string date;
    public int length;

    public abstract double returnDistance();
    
    public abstract double returnSpeed();
    public abstract double returnPace();
    public abstract void printSummary();
}