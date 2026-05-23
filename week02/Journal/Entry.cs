// file holding the Entry class for the Journal Program.

using System.Runtime.Serialization;

public class Entry
{
    public string _entryDate;
    public string _prompt;
    public string _response;
    public string _scale;
    public void Display()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_prompt}");
        Console.WriteLine(_response);
        Console.WriteLine($"On a scale from 1(Bad)-10(Good) I feel: {_scale}");
        Console.WriteLine();
    }
}