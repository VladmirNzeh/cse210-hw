using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Job named job1
        Job job1 = new Job();

        // Set the member variables for job1 using dot notation
        job1._jobTitle = "IT Support";
        job1._company = "Nicole Sinclair";
        job1._startYear = 2020;
        job1._endYear = 2023;

        // Create a second instance of Job named job2
        Job job2 = new Job();

        // Set the member variables for job2 using dot notation
        job2._jobTitle = "Software Engineer";
        job2._company = "AfricanIntern";
        job2._startYear = 2023;
        job2._endYear = 2024;

        Resume  myResume = new Resume();
        myResume._PersonName = "Emmanuel Nzeh";

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();
    }
}