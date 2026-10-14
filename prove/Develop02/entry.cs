namespace Journal;

// public class Entry
// {
//      // attributes
//     public string _date;
//     public string _prompt;
//     public string _response;

//     // behavior
//     public void Display()
//     {
//         Console.WriteLine($"Prompt: {_prompt}");
//     }
// }


public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

    public void Display()
    {
        Console.WriteLine($"Prompt: {_prompt}");
    }

    public static List<string> GetPrompts()
    {
        return new List<string>
        {
            "What is the capital of France?",
            "What did you eat for breakfast today?",
            "What is one thing you are grateful for today?",
            "Who is a person you admire and why?",
            "If you could live anywhere in the world, where would it be and why?",
            "What goal do I want to accomplish tomorrow?"
        };
    }
}