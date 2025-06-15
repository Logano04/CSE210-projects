public class Assignment
{
    private string _studentName;
    private string _topic;

    //constructor (must match class name and have no return type)
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}