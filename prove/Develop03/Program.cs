using System;

// What I did for the stretch assignment is instead of displaying the same scripture every time a user is memorizing I did multiple scriptures
// and the program will randomly select one from the list

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        Reference reference = new Reference("D&C", 3, 3);

        string text = "Remember, remember that it is not the work of God that is frustrated, but the work of men;";

        List<Word> words = new List<Word>();

        foreach (string word in text.Split(' '))
        {
            words.Add(new Word(word));
        }

       Scripture scripture = new Scripture(reference, words);

        // the stretch challenge added
       scriptures.Add(scripture);

       Reference reference2 = new Reference("Proverbs", 3, 5, 6);

        string text2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        List<Word> words2 = new List<Word>();

        foreach (string word in text2.Split(' '))
        {
            words2.Add(new Word(word));
        }

        Scripture scripture2 = new Scripture(reference2, words2);

        scriptures.Add(scripture2);




        Random random = new Random();

        int randomIndex = random.Next(scriptures.Count);

        Scripture selectedScripture = scriptures[randomIndex];


        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());

        string userInput = "";

   while (userInput != "quit" && !selectedScripture.IsCompletelyHidden())
    {
        Console.WriteLine();
        Console.WriteLine("Press Enter to hide words or type 'quit' to exit.");

        userInput = Console.ReadLine();

        if (userInput == "quit")
        {
            break;
        }

        selectedScripture.HideRandomWords();

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
    }
        }
}