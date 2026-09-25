using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();


        int givennumber = -1;
        while (givennumber != 0)
        {
            Console.Write("Enter a number (0 to 100): ");
            
            string userResponse = Console.ReadLine();
            givennumber = int.Parse(userResponse);
            
            if (givennumber != 0)
            {
                numbers.Add(givennumber);
            }
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The largest number is: {max}");
    }
}