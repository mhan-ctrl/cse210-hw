public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you to be mindful by focusing on your breathing")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("What kind of breathing would you like?");
        Console.WriteLine("1. Standard");
        Console.WriteLine("2. Relaxed");
        Console.WriteLine("3. Box");

        int breathingType;

        while (!int.TryParse(Console.ReadLine(), out breathingType) || breathingType < 1 || breathingType > 3)
        {
            Console.WriteLine("Invalid input. Please enter 1, 2, or 3:");
        }

        int inhale = 4;
        int exhale = 4;
        int hold = 0;

        switch (breathingType)
        {
            case 1:
                inhale = 4;
                exhale = 4;
                hold = 0;
                break;
            case 2:
                inhale = 4;
                exhale = 6;
                hold = 0;
                break;
            case 3:
                inhale = 4;
                exhale = 4;
                hold = 4;
                break;
        }
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);

        DateTime activityEnd = DateTime.Now.AddSeconds(_duration);

        Console.Clear();

        while (DateTime.Now < activityEnd)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in...");
            ShowCountDown(inhale);
            if (hold > 0)
            {
                Console.WriteLine("Hold...");
                ShowCountDown(hold);
            }
            Console.WriteLine("Breathe out...");
            ShowCountDown(exhale);
            if (hold > 0)
            {
                Console.WriteLine("Hold...");
                ShowCountDown(hold);
            }
        }

        DisplayEndingMessage();

    }

}