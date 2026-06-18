using System;
//added some additional error checking at certain points in the program. Particularly from user input.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Display Score");
            Console.WriteLine("7. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();
            Console.WriteLine();
            if (choice == "1")
            {
                manager.CreateGoal();
            }
            else if (choice == "2")
            {
                manager.ListGoalDetails();
            }
            else if (choice == "3")
            {
                manager.RecordEvent();
            }
            else if (choice == "4")
            {
                manager.SaveGoals();
            }
            else if (choice == "5")
            {
                manager.LoadGoals();
            }
            else if (choice == "6")
            {
                manager.DisplayPlayerInfo();
            }
            else if (choice == "7")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
        }
    }
}