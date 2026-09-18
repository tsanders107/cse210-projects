using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int number = int.Parse(gradePercentage);

        string lettergrade = "";

        if (number >= 96)
            {
                lettergrade = "A+";
            }

            else if (number == 95)
                {
                    lettergrade = "A";
                }

            else if (number >= 94)
                {
                    lettergrade = "A-";
                }

        else if (number >= 80)
            {
                lettergrade = "B";
            }

        else if (number >= 70)
            {
                lettergrade = "C";
            }

        else if (number >= 60)
            {
                lettergrade = "D";
            }

        else if (number <= 59)
            {
                lettergrade = "F";
            }

        Console.WriteLine($"Your letter grade is {lettergrade}");

        if (number >= 70)
            {
                Console.WriteLine("Good job you passed :)");
            }
        else Console.WriteLine("Keep trying!");

    }
}