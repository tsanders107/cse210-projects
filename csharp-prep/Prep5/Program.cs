using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        int personnumber = PromptUserNumber();
        string personname = PromptUserName();

        int squarenumber = SquareNumber(personnumber);

        int birthyear;
        PromptUserBirthYear(out birthyear);


        DisplayResult(personname, squarenumber, birthyear);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    
    static void PromptUserBirthYear(out int birthyear)
    {
        Console.Write($"please enter the year you were born: ");
        birthyear = int.Parse(Console.ReadLine());

    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square, int birthYear)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
        Console.WriteLine($"{name}, you will turn {2026 - birthYear} this year.");
    }
}