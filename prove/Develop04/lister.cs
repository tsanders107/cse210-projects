public class Lister : Activity
{
    private List<string> _prompts;
    private Random _random;

    public Lister()
        : base(
            "Listing Activity",
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        )
    {
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        _random = new Random();
    }

    public void Run()
    {
        InteractPrologue();

        int promptIndex = _random.Next(_prompts.Count);
        Console.WriteLine(_prompts[promptIndex]);

        Console.WriteLine("You may begin listing in:");
        ShowCountdown(5);

        Console.WriteLine("Start listing items:");

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine($"You listed {items.Count} items.");

        InteractEpilogue();
    }
}