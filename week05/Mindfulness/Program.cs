using System;

class Program
{
    static void Main(string[] args)
    {
        //Creative Addition was a set of options for the breathing exercise the user can select from.

        bool running = true;

        while (running)
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("_-_-_-_-_-_-_-_-_-_");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Listing Activity");
            Console.WriteLine("3. Reflecting Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Please enter a number(1-4): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;

                case "2":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;

                case "3":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;

                case "4":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid Input. Press enter to try again.");
                    Console.ReadLine();
                    break;
            }

            if (running)
            {
                Console.WriteLine();
                Console.WriteLine("Press enter to return to the menu...");
                Console.ReadLine();
            }
        }
    }
}