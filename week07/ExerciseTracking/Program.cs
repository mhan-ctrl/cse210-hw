using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        List<Activity> activities = new List<Activity>();
        Running run = new Running(DateTime.Now, 10.0, 5);
        StationaryBicycle bike = new StationaryBicycle(DateTime.Now, 10.0, 15);
        Swimming swim = new Swimming(DateTime.Now, 30.0, 20);
        activities.Add(run);
        activities.Add(bike);
        activities.Add(swim);

        foreach (Activity activity in activities)
        {
            Console.WriteLine($"{activity.GetSummary()}");
            Console.WriteLine();
        }
    }
}