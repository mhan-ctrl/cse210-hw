using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        // Console.Write("What is the magic number? ");
        // string magicString = Console.ReadLine();
        // int magicNumber = int.Parse(magicString);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guessNumber = 0;

        do
        {
            Console.Write("What is your guess? ");
            string guessString = Console.ReadLine();
            guessNumber = int.Parse(guessString);

            if (guessNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
        } while (guessNumber != magicNumber);
    }
}