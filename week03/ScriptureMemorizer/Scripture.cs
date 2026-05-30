//
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;

public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] parts = text.Split(' ');
        foreach (string part in parts)
        {
            Word word = new Word(part);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            List<Word> options = new List<Word>();

            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                {
                    options.Add(word);
                }
            }
            if (options.Count == 0)
            {
                break;
            }
            int index = _random.Next(options.Count);
            Word selected = options[index];
            selected.Hide();
        }
    }
    public void ResetVisibility()
    {
        foreach (Word word in _words)
        {
            word.Show();
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            result += " " + word.GetDisplayText();
        }
        return result;
    }
    public bool IsCompletelyHidden()
    {
        bool totallyHid = true;
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                totallyHid = false;
                break;
            }
        }
        return totallyHid;
    }
}