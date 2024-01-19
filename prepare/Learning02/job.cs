public class jobExperience
{
    public string jobTitle;
    public string company;
    public string startYear;
    public string endYear;
    public string location;

    public void display()
    {
    Console.WriteLine($"{_jobTitle} at {_company} from {_startYear} to {_endYear} in {_location}.");
    }
}

