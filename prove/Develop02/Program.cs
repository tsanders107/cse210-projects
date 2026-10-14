
namespace Journal;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, journal program!");

        List<Journal> myJournals = new List<Journal>();

        Journal journal1 = new Journal();
        journal1._date = "2023-06-01";
        journal1._prompt = "What is the capital of France?";
        journal1._response = "The capital of France is Paris.";
        myJournals.Add(journal1);

        Journal journal2 = new Journal();
        journal2._date = "2026-12-01";
        journal2._prompt = "What did you eat for breakfast today?";
        journal2._response = "I ate cereal and an egg and cheese sandwich today.";
        myJournals.Add(journal2);

        Journal journal3 = new Journal();
        journal3._date = "2026-12-01";
        journal3._prompt = "What is one thing you are grateful for today?";
        journal3._response = "I am grateful for the opportunity I had to learn how to ride a horse.";
        myJournals.Add(journal3);

        Journal journal4 = new Journal();
        journal4._date = "2026-12-01";
        journal4._prompt = "Who is a person you admire and why?";
        journal4._response = "I admire my grandma because she is a hard worker and always puts her family first.";
        myJournals.Add(journal4);

        Journal journal5 = new Journal();
        journal5._date = "2026-12-01";
        journal5._prompt = "If you could live anywhere in the world, where would it be and why?";
        journal5._response = "I would live in Japan because of the wonderful culture and delicious food.";
        myJournals.Add(journal5);

        string userEntry = "";

        while (userEntry != "5")
        {
            string displayMenu = @"
Please select an option:
1. Write a new journal entry
2. Display all journal entries
3. Save journal entries to a file
4. Load journal entries from a file
5. Exit";

            Console.WriteLine(displayMenu);
            Console.Write("Choose an option: ");
            userEntry = Console.ReadLine() ?? "";

            if (userEntry == "1")
            {
                List<string> prompts = Entry.GetPrompts();
                Random random = new Random();

                string randomPrompt =
                    prompts[random.Next(prompts.Count)];

                Console.WriteLine($"Prompt: {randomPrompt}");
                Console.Write("What is your response? ");
                string response = Console.ReadLine() ?? "";

                Journal newEntry = new Journal();
                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._prompt = randomPrompt;
                newEntry._response = response;

                myJournals.Add(newEntry);

                Console.WriteLine("Entry added!");
            }
            else if (userEntry == "2")
            {
                Console.WriteLine("Displaying all journal entries:");

                foreach (Journal j in myJournals)
                {
                    j.Display();
                }
            }
            else if (userEntry == "3")
            {
                Console.Write("Enter a filename: ");
                string filename = Console.ReadLine() ?? "";

                using (StreamWriter outputFile =
                    new StreamWriter(filename))
                {
                    foreach (Journal j in myJournals)
                    {
                        outputFile.WriteLine(
                            $"{j._date}~{j._prompt}~{j._response}"
                        );
                    }
                }

                Console.WriteLine("Journal saved successfully.");
            }
            else if (userEntry == "4")
            {
                Console.Write("Enter a filename: ");
                string filename = Console.ReadLine() ?? "";

                if (File.Exists(filename))
                {
                    myJournals.Clear();

                    string[] lines = File.ReadAllLines(filename);

                    foreach (string line in lines)
                    {
                        string[] parts = line.Split('~');

                        if (parts.Length >= 3)
                        {
                            Journal loadedEntry = new Journal();
                            loadedEntry._date = parts[0].Trim();
                            loadedEntry._prompt = parts[1].Trim();
                            loadedEntry._response = parts[2].Trim();

                            myJournals.Add(loadedEntry);
                        }
                    }

                    Console.WriteLine("Journal loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }
            }
            else if (userEntry == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }

            Console.WriteLine();
        }
    }
}