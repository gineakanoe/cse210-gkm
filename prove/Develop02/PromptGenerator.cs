public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What was the most beautiful thing you witnessed today?",
        "Who is someone you love?",
        "What did you look forward to the most today?"
    };
    Random random = new Random();

    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        string chosenPrompt = _prompts[randomIndex];

        return chosenPrompt;
    }
}