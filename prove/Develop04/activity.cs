public class Activity
{
    private string _title;
    private string _desc;
    private int _duration;
    private Timer _timer;


    public Activity(string title, string desc)
    {
        _title = title;
        _desc = desc;
        _timer = new Timer();
    }

    public int GetDuration()
    {
        return _duration;

    }

      protected void ShowCountdown(int seconds)
    {
        _timer.ShowCountdown(seconds);
    }

    protected void Spinner(int seconds)
    {
        _timer.Spinner(seconds);
    }

    public void InteractPrologue()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_desc);
        Console.Write("How many seconds long would you like for your activity? ");

        while (true)
            {
                string input = Console.ReadLine();

                if (int.TryParse(input, out _duration) && _duration > 0)                // exceeding my requirments 
                {
                    break;
                }

                Console.Write("Please enter a positive whole number: ");
            }

        Console.Clear();
        Console.WriteLine("Get ready...");
        _timer.ShowCountdown(3);
    }

    public void InteractEpilogue()
    {
        Console.WriteLine("Good Job completing the activity!");
        Console.WriteLine($"You spent {_duration} seconds on this {_title} activity.");
        _timer.Spinner(3);
    }

}