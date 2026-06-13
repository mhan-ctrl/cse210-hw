public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?","What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heros?"
    };

    public ListingActivity() : base("Listing Activity", "This Activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        RandomPrompt();
        List<string> items = GetListFromUser();
        _count = items.Count;
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    public void RandomPrompt()
    {
        Random rand = new Random();
        int prompt = rand.Next(_prompts.Count);
        Console.WriteLine($"{_prompts[prompt]}");
        ShowCountDown(9);
        Console.Clear();
        Console.WriteLine("Begin making a list, pressing enter after each entry.");
        Console.WriteLine();
    }
    
    public List<string> GetListFromUser()
    {
        List<string> listing = new List<string>();

        DateTime activityEnd = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < activityEnd)
        {
            Console.Write("> ");
            string listItem = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(listItem))
            {
                listing.Add(listItem);
            }
        }
        return listing;
    }
}