public class Timer
{
    public void Spinner(int seconds)
    {
        string[] symbols = { "|", "/", "-", "\\" };

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(symbols[i % 4]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b \b");
            Console.WriteLine();
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine();
        }
    }
}