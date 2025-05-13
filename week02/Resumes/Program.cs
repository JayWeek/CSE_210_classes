using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");


        Job job1 = new Job();
        Job job2 = new Job();

        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2025;

        job2._jobTitle = "Hacker";
        job2._jobCompany = "Google";
        job2._startYear = 2020;
        job2._endYear = 2024;

        Resumes myResumes = new Resumes();

        myResumes._jobs.Add(job1);
        myResumes._jobs.Add(job2);
        myResumes._name = "JayWeek";

        myResumes.DisplayRezume();
    }
}
