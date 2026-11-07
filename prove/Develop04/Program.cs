using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing breathing = new Breathing();
                breathing.Run();
            }
            else if (choice == "2")
            {
                Reflection reflection = new Reflection();
                reflection.Run();
            }
            else if (choice == "3")
            {
                Lister lister = new Lister();
                lister.Run();
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Thread.Sleep(1500);
            }
        }
    }
}