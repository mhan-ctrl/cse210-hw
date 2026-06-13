public class Activity
{
    private string _name;
    private string _description;
    protected int _duration; //still accessible by the child classes
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}.");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like your session to be: ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done.\n");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.\n");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {//there isn't a real answer
        string[] spinner = { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            foreach (string s in spinner)
            {
                if (DateTime.Now >= endTime)
                {
                    break;
                }
                Console.Write(s);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}