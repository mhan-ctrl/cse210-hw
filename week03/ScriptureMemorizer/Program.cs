using System;
using System.Configuration.Assemblies;
using System.Data;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference reference = new Reference("Doctrine and Covenants", 121, 45, 46);
        Scripture scripture = new Scripture(reference, "Let thy bowels also be full of charity towards all men, and to the household of faith, and let virtue garnish thy thoughts unceasingly; then shall thy confidence wax strong in the presence of God; and the doctrine of the priesthood shall distil upon thy soul as the dews from heaven. The Holy Ghost shall be thy constant companion, and thy scepter an unchanging scepter of righteousness and truth; and thy dominion shall be an everlasting dominion, and without compulsory means it shall flow unto thee forever and ever.");

        string userInput = "";

        do
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to quit.");
            userInput = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            if (userInput == "quit")
            {
                break;
            }
            scripture.HideRandomWords(1);
        } while (true);
        
    }
}