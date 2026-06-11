using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        Assignment Mark = new Assignment("Mark", "Geology");
        Console.WriteLine($"{Mark.GetSummary()}");

        MathAssignment John = new MathAssignment("John", "Philosophy", "Section 10.2A", "Prompts 1,2 and 4");
        Console.WriteLine(John.GetHomeworkList());

        WritingAssignment Mary = new WritingAssignment("Mary", "History", "The Times and Trials of the Venerable Carpet");
        Console.WriteLine(Mary.GetWritingInformation());
    }
}