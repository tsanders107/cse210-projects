public class Breathing : Activity
{
    public Breathing()
        : base(
            "Breathing Activity",
            "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing."
        )
    {
    }
   public void Run()
    {
        InteractPrologue();

        int elapsed = 0;

        while (elapsed < GetDuration())
        {
            int remaining = GetDuration() - elapsed;
            int breathTime = Math.Min(4, remaining);

            Console.WriteLine("Breathe in...");
            ShowCountdown(breathTime);
            elapsed += breathTime;

            if (elapsed < GetDuration())
            {
                remaining = GetDuration() - elapsed;
                breathTime = Math.Min(4, remaining);

                Console.WriteLine("Breathe out...");
                ShowCountdown(breathTime);
                elapsed += breathTime;
            }
        }

        InteractEpilogue();
    }
}