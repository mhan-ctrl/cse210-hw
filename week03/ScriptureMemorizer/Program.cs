using System;
using System.Configuration.Assemblies;
using System.Data;
using System.Net;
//added a function to let the user reveal the scripture again (starting over)
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
            Console.WriteLine("Press enter to continue, type 'reveal' to reset, or type 'quit' to quit.");
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                break;
            }
            if (userInput == "reveal")
            {
                scripture.ResetVisibility();
            }
            else
            {
                scripture.HideRandomWords(1);
            }

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        } while (true);
        
    }
}