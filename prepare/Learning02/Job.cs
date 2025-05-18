public class Job
{
    public string _company;
    public string _jobTitle;
    public string _startYear;
    public string _endYear;

    public Job()
    {
        
    }
    void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_startYear} - {_endYear}) at {_company}");
    }
}