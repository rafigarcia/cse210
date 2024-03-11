using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2017;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Software Developer";
        job2._company = "Apple";
        job2._startYear = 2019;
        job2._endYear = 2023;

        Job job3 = new Job();
        job3._jobTitle = "Software Developer";
        job3._company = "Google";
        job3._startYear = 2023;
        job3._endYear = 2025;

        Resume myResume = new Resume();
        
        myResume._name = "Rosalita Flores";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        myResume.DisplayResume();

    }
}