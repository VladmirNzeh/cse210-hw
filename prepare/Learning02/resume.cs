using System;

public class Resume
{
    public string _name;

    // Make sure to initialize your list to a new List before you use it.
    public List<jobExperience> _jobs = new List<jobExperience>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("jobsExperience:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (jobExperience job in _jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}