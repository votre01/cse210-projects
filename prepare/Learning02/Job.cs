// Job class
public class Job
{
    // Members
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public Job()
    {
    }

    public void DisplayJobDetails ()
    {
        //Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }
}

