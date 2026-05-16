using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 0;

        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        //we could do loops, but because of .NET average, max, min, and sum are built in.
        double avg = numbers.Average();
        int largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}