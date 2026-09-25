using System;
using System.Globalization;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicnumber = randomGenerator.Next(1, 101);

       int numberguess = -1;

       while (numberguess != magicnumber)
        {
            Console.Write("What is your guess? ");
            numberguess = int.Parse(Console.ReadLine());

            if (magicnumber > numberguess)
            {
                Console.WriteLine("Go Higher");
            }
            else if (magicnumber < numberguess)
            {
                Console.WriteLine("Go Lower");
            }
            else
            {
                Console.WriteLine("Correct Guess!");
            }
        }
    }
}