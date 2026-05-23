// Class for the Prompt Generator

using Microsoft.VisualBasic;
public class PromptGenerator
{
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person you met today?",
        "Where did you see God's hand in your life?",
        "What new thing did you learn?",
        "What did you accomplish today?",
        "Who did you talk to and what did you talk about?",
        "How are you feeling about your goals?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts[index];
    }
}