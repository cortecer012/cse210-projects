using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();

        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Developer";
        job1._startYear = 2023;
        job1._endYear = 2030;
        
        Job job2 = new Job();

        job2._companyName = "Apple";
        job2._jobTitle = "Software Developer";
        job2._startYear = 2023;
        job2._endYear = 2030;

        Resume resume = new Resume();

        resume._name = "Julio Cortecero";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}