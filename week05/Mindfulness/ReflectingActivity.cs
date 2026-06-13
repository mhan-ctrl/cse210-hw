public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"
    };


    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        ShowSpinner(6);

        DateTime activityEnd = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < activityEnd)
        {
            string question = GetRandomQuestion();
            DisplayQuestion(question);
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random rand = new Random();
        return _prompts[rand.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];

    }
    public void DisplayPrompt(string prompt)
    {
        Console.WriteLine("Take some time to ponder the following: ");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, please press enter to start...");
        Console.ReadLine();
        Console.WriteLine("Please consider the answers to the following questions");
    }
    public void DisplayQuestion(string question)
    {
        Console.Clear();
        Console.WriteLine();
        Console.Write($"-- {GetRandomQuestion()} --");
        ShowSpinner(8);
    }
}