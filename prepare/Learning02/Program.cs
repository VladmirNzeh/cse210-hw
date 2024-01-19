using System;

class Program
{
    static void Main(string[] args)
    {
        jobExperience job1 = new jobExperience();
        job1.jobTitle = "IT Support";
        job1.company = "Nicole Sinclair";
        job1.startYear = "2020";
        job1.endYear = "2021";
        job1.location = "Ikeja, Lagos";

        jobExperience job2 = new jobExperience();
        job2.jobTitle = "Software Engineer";
        job2.company = "AfricanIntern";
        job2.startYear = "2023";
        job2.endYear = "2024";
        job2.location = "Lagos, Nigeria";

        Resume myResume = new Resume();
        myResume._name = "Emmanuel Chidiebere Nzeh";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}