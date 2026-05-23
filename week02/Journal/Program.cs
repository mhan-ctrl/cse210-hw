using System;
using System.IO.Enumeration;

// Added another entry that asks how the users feels on a scale from 1 to 10.

Console.WriteLine("Welcome to your Journal Assistant");
Console.WriteLine("");
Journal journal = new Journal();
PromptGenerator prompting = new PromptGenerator();
int option = 0;

do
{
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Make a new Entry");
    Console.WriteLine("2. Display the Entries");
    Console.WriteLine("3. Save the Entries");
    Console.WriteLine("4. Load Entries");
    Console.WriteLine("5. Quit");
    string choice = Console.ReadLine();
    option = int.Parse(choice);

    if (option == 1)
    {
        string prompt = prompting.GetRandomPrompt();
        Console.WriteLine(prompt);

        string response = Console.ReadLine();

        Console.WriteLine("On a scale from 1(Bad) to 10(Good), how do you feel?");

        string scale = Console.ReadLine();

        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._response = response;
        entry._entryDate = DateTime.Now.ToString("MM-dd-yyyy:mm");
        entry._scale = scale;

        journal.AddEntry(entry);
    }
    else if (option == 2)
    {
        journal.DisplayEntries();
    }
    else if (option == 3)
    {
        Console.Write("Please enter filename: ");
        string name = Console.ReadLine();
        if (!name.EndsWith(".txt"))
        {
            name += ".txt";
        }
        journal.Save(name);
    }
    else if (option == 4)
    {
        Console.Write("Please enter filename: ");
        string name = Console.ReadLine();
        if (!name.EndsWith(".txt"))
        {
            name += ".txt";
        }
        if (File.Exists(name))
        {
            journal.Load(name);
        }
        else
        {
            Console.WriteLine("File not found.");
        }

    }
    else if (option == 5)
    {
        Console.WriteLine("See you later!");
    }
    else
    {
        Console.WriteLine("Invalid input, try again.");
    }
} while (option != 5);
