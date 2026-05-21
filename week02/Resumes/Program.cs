using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microslop";
        job1._startYear = 1980;
        job1._endYear = 2020;

        Job job2 = new Job();
        job2._jobTitle = "Janitor";
        job2._company = "IAapple";
        job2._startYear = 1970;
        job2._endYear = 9999;

        job1.Display();
        job2.Display();
    }
}